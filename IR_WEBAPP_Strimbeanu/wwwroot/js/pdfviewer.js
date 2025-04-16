function levenshtein(a, b) {
    const matrix = Array.from({ length: b.length + 1 }, (_, i) => [i]);
    matrix[0] = Array.from({ length: a.length + 1 }, (_, j) => j);

    for (let i = 1; i <= b.length; i++) {
        for (let j = 1; j <= a.length; j++) {
            if (b.charAt(i - 1) === a.charAt(j - 1)) {
                matrix[i][j] = matrix[i - 1][j - 1];
            } else {
                matrix[i][j] = Math.min(
                    matrix[i - 1][j] + 1,
                    matrix[i][j - 1] + 1,
                    matrix[i - 1][j - 1] + 1
                );
            }
        }
    }

    return matrix[b.length][a.length];
}

pdfjsLib.GlobalWorkerOptions.workerSrc = `https://cdnjs.cloudflare.com/ajax/libs/pdf.js/3.11.174/pdf.worker.min.js`;

window.searchInPdf = async function (query) {
    const iframe = document.getElementById('pdfViewer');
    const url = iframe.src.split("#")[0];
    const loadingTask = pdfjsLib.getDocument(url);
    const pdf = await loadingTask.promise;

    const allMatches = [];

    for (let pageNum = 1; pageNum <= pdf.numPages; pageNum++) {
        const page = await pdf.getPage(pageNum);
        const textContent = await page.getTextContent();
        const text = textContent.items.map(i => i.str).join(" ");
        const lowerText = text.toLowerCase();
        const queryLower = query.toLowerCase();

        const words = lowerText.match(/\b\w+\b/g) || [];

        for (let word of words) {
            const distance = levenshtein(queryLower, word);
            const isExact = word === queryLower;

            if (distance <= 3) {
                const index = lowerText.indexOf(word);
                const snippet = text.substring(index, index + 100);

                allMatches.push({
                    pageNumber: pageNum,
                    snippet,
                    word,
                    distance,
                    exact: isExact
                });
            }
        }
    }

    window._pdfMatches = allMatches;
    return allMatches.length;
};

window.getSearchMatchesPage = function (pageIndex, pageSize) {
    const start = pageIndex * pageSize;
    const end = start + pageSize;
    return window._pdfMatches?.slice(start, end) || [];
};

window.goToMatch = function (pageNumber) {
    const iframe = document.getElementById('pdfViewer');
    const baseUrl = iframe.src.split("#")[0].split("?")[0];
    const bust = new Date().getTime();
    iframe.src = `${baseUrl}?v=${bust}#page=${pageNumber}`;
};
