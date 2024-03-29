if (document.readyState == "complete") FoELogin();
else {
    document.addEventListener("DOMContentLoaded", () => {
        FoELogin();
    });
}

async function FoELogin() {
    await CefSharp.BindObjectAsync("jsInterface");
    if (window.location.href.indexOf("##server##0") <= 0) {
        await FoETimer(1000);
        fetch("https://##server##.forgeofempires.com/glps/login_check", {
            "credentials": "include",
            "headers": {
                "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:73.0) Gecko/20100101 Firefox/73.0",
                "Accept": "application/json, text/plain, */*",
                "Accept-Language": "de,en-US;q=0.7,en;q=0.3",
                "X-XSRF-TOKEN": "###XSRF-TOKEN###",
                "Content-type": "application/x-www-form-urlencoded; charset=UTF-8",
                "X-Requested-With": "XMLHttpRequest",
                "Pragma": "no-cache",
                "Cache-Control": "no-cache"
            },
            "referrer": "https://##server##.forgeofempires.com/",
            "body": "login%5Buserid%5D=###USERNAME###&login%5Bpassword%5D=###PASSWORD###&login%5Bremember_me%5D=false",
            "method": "POST",
            "mode": "cors"
        }).catch((e) => {
            console.log(e);
        }).then(async (x) => {
            window.location = "https://##server##0.forgeofempires.com/page/";
        });
    }
    else {
        await FoETimer(1000);
        fetch("https://##server##0.forgeofempires.com/start/index?action=fetch_worlds_for_login_page", {
            "credentials": "include",
            "headers": {
                "accept": "text/plain, */*; q=0.01",
                "accept-language": "de",
                "cache-control": "no-cache",
                "content-type": "application/x-www-form-urlencoded; charset=UTF-8",
                "pragma": "no-cache",
                "sec-fetch-mode": "cors",
                "sec-fetch-site": "same-origin",
                "x-requested-with": "XMLHttpRequest"
            },
            "referrer": "https://##server##0.forgeofempires.com/page/",
            "referrerPolicy": "no-referrer-when-downgrade",
            "body": "json=null",
            "method": "POST",
            "mode": "cors"
        }).then(res => {
            res.text().then(body => {
                if (##t##){
                window.jsInterface.hook(body, "Cities", "ChooseServer", "");
            }else {
                fetch("https://##server##0.forgeofempires.com/start/index?action=play_now_login", {
                    "credentials": "include",
                    "headers": {
                        "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:73.0) Gecko/20100101 Firefox/73.0",
                        "Accept": "text/plain, */*; q=0.01",
                        "Accept-Language": "de,en-US;q=0.7,en;q=0.3",
                        "Content-Type": "application/x-www-form-urlencoded; charset=UTF-8",
                        "X-Requested-With": "XMLHttpRequest",
                        "Pragma": "no-cache",
                        "Cache-Control": "no-cache"
                    },
                    "referrer": "https://##server##0.forgeofempires.com/page/",
                    "body": "json=%7B%22world_id%22%3A%22" + ##city## + "%22%7D",
                    "method": "POST",
                    "mode": "cors"
                }).then(res => res.json()
                    .then((body) => {
                        window.location = body['login_url'];
                    }));
            }

        });
    });
}
}

function FoETimer(time) {
    if (time == void 0) time = 500;
    return new Promise((res) => {
        setTimeout(() => { res(); }, time);
    });
}