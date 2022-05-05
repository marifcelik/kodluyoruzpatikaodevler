const http = require('http');
const host = 'localhost';
const port = 5000;

const sayfalar = {
    '/': '<h2>index sayfası</h2>',
    '/index': '<h2>index sayfası</h2>',
    '/hakkimda': '<h2>hakkımda sayfası</h2>',
    '/iletisim': '<h2>iletişim sayfası</h2>'
}

const server = http.createServer((req, res) => {
    res.writeHead(200, { 'Content-type': 'text/html; charset=utf-8' });
    let url = req.url;
    if (sayfalar[url])
        res.write(sayfalar[url]);
    else
        res.write('<h2>404</h2>')
    res.end();
});

server.listen(port, host, () => {
    console.log(`${host}' ta ${port} portu çalışıyor`);
})