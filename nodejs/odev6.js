const Koa = require('koa');
const app = new Koa();
const port = 3000;

const sayfalar =
{
    '/': '<h1>index sayfası</h1>',
    '/index': '<h1>index sayfası</h1>',
    '/hakkimda': '<h1>hakkımda sayfası</h1>',
    '/iletisim': '<h1>iletişim sayfası</h1>'
}

app.use((ctx => {
    let url = ctx.URL.pathname.toString();
    console.log(url);
    ctx.body = sayfalar[url] || '<h1>404 sayfa bulunamadı</h1>'
}));

app.listen(port);