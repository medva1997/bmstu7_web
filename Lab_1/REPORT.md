# Лабораторная работа № 1
[Оригинал условия](https://docs.google.com/document/d/12X1aQF72_Hr9OeTsHcBjE4W9VzQsZgoD3Vlcf0BZ24U/edit)

### 1. Базовая часть работы
### 1.1. Цель данной работы – ознакомится с применением протокола HTTP на практике, в реальных системах. Каждый из рассмотренных типов запросов предлагается отправить на несколько известных интернет-сервисов. Впрочем, сервисы указаны лишь как примеры и при желании вы можете выбрать другие (социальные сети, почта, облака, новостные сайты и т.д.).  
### 1.2. С помощью специального ПО (Postman, либо многочисленные аналоги, например, Restlet Clent - расширение для Chrome) вручную отправить следующие запросы и ответить на предлагаемые вопросы.
 
#### 1.2.1. Запрос OPTIONS. Отправьте запрос на http://mail.ru, http://ya.ru, www.rambler.ru, https://www.google.ru, https://github.com/,   www.apple.com/. Для чего используется запрос OPTIONS? Какие коды ответов приходят при этом запросе? Какие сайты правильно обработали запрос и вернули ожидаемые данные?

TODO
#### 1.2.2. Запрос HEAD.  vk.com, www.apple.com, www.msn.com. Для чего нужен запрос HEAD? Какой сайт прислал ожидаемый ответ?

```
alexey@alexey-L380:~/Downloads$ curl  -i --head http://vk.com
HTTP/1.1 418 
Server: VK
Date: Sat, 07 Sep 2019 14:47:08 GMT
Content-Length: 0
Connection: keep-alive
X-Frontend: front202922
Access-Control-Expose-Headers: X-Frontend


alexey@alexey-L380:~/Downloads$ curl  -i --head http://www.apple.com
HTTP/1.1 301 Moved Permanently
Server: AkamaiGHost
Content-Length: 0
Location: https://www.apple.com/
Cache-Control: max-age=0
Expires: Sat, 07 Sep 2019 14:47:46 GMT
Date: Sat, 07 Sep 2019 14:47:46 GMT
Connection: keep-alive
strict-transport-security: max-age=31536000
Set-Cookie: geo=RU; path=/; domain=.apple.com
Set-Cookie: ccl=LSX97Qv1O/3TsVPEjaYI+g==; path=/; domain=.apple.com


alexey@alexey-L380:~/Downloads$ curl  -i --head http://www.msn.com
HTTP/1.1 302 Found
Cache-Control: no-cache, no-store, no-transform
Pragma: no-cache
Content-Length: 142
Content-Type: text/html; charset=utf-8
Expires: -1
Location: http://www.msn.com/ru-ru/
Vary: User-Agent
Set-Cookie: PreferencesMsn=eyJIb21lUGFnZSI6eyJTdHJpcGVzIjpbXSwiTWVTdHJpcGVNb2R1bGVzIjpbXSwiTWFya2V0Q29uZmlndXJhdGlvbiI6eyJNYXJrZXQiOiJydS1ydSIsIlN1cHByZXNzUHJvbXB0IjpmYWxzZSwiUHJlZmVycmVkTGFuZ3VhZ2VDb2RlIjoicnUtcnUiLCJDb3VudHJ5Q29kZSI6IlJVIn19LCJFeHBpcnlUaW1lIjo2MzczNTA4Njg5NzYyOTE4MzQsIlZlcnNpb24iOjF90; domain=msn.com; expires=Mon, 07-Sep-2020 14:48:17 GMT; path=/; HttpOnly
Set-Cookie: marketPref=ru-ru; domain=msn.com; expires=Mon, 07-Sep-2020 14:48:17 GMT; path=/; HttpOnly
Access-Control-Allow-Origin: *
X-AspNetMvc-Version: 5.2
X-AppVersion: 20190824_17864432
X-Activity-Id: d1602783-b836-4ef6-99cb-a3589d896415
X-Az: {did:b24a0ea2b3ba45a59fc1d4d299c5ebc1, rid: 18, sn: neurope-prod-hp, dt: 2019-08-31T16:26:17.4648862Z, bt: 2019-08-25T00:14:05.8140966Z}
X-UA-Compatible: IE=Edge;chrome=1
X-Content-Type-Options: nosniff
X-FRAME-OPTIONS: SAMEORIGIN
X-Powered-By: ASP.NET
Access-Control-Allow-Methods: HEAD,GET,OPTIONS
X-XSS-Protection: 1
X-MSEdge-Ref: Ref A: D1602783B8364EF699CBA3589D896415 Ref B: STOEDGE1007 Ref C: 2019-09-07T14:48:17Z
Date: Sat, 07 Sep 2019 14:48:17 GMT
```
Выводы 
  * vk.com ответил кодом 418 (I’m a teapot — Этот код был введен в 1998 году как одна из традиционных первоапрельских шуток IETF в RFC 2324.Не ожидается, что данный код будет поддерживаться реальными серверами)
  * www.apple.com ответил кодом 301 (Moved Permanently — запрошенный документ был окончательно перенесен на новый URI, указанный в поле Location заголовка. Некоторые клиенты некорректно ведут себя при обработке данного кода. Появился в HTTP/1.0.)
 * www.msn.com ответил кодом 302 (Moved Temporarily — запрошенный документ временно доступен по другому URI, указанному в заголовке в поле Location.)

> Для чего нужен запрос HEAD?
> > TODO

> Какой сайт прислал ожидаемый ответ?
> > vk.com ответил кодом которого не существует(самый не правильный ответ), www.apple.com сообщил не необхомости редиректа на https версию сайта (безопасно), www.msn.com перенаправили на росcиийскую версию сайта http://www.msn.com/ ru-ru/ (не безопасно)

#### 1.2.3. Запросы GET и POST. Отправьте по запросу на yandex.ru, google.com и apple.com. Что они вернули? Что содержится в теле ответа?
```
alexey@alexey-L380:~/Downloads$ curl  -i -X GET http://yandex.ru
HTTP/1.1 302 Found
Location: https://yandex.ru/
Date: Sat, 07 Sep 2019 15:02:13 GMT
X-Content-Type-Options: nosniff
Set-Cookie: yandexuid=3938418171567868533; Expires=Tue, 04-Sep-2029 15:02:13 GMT; Domain=.yandex.ru; Path=/
Content-Length: 0
Expires: Sat, 07 Sep 2019 15:02:14 GMT
P3P: policyref="/w3c/p3p.xml", CP="NON DSP ADM DEV PSD IVDo OUR IND STP PHY PRE NAV UNI"
Last-Modified: Sat, 07 Sep 2019 15:02:14 GMT
Cache-Control: no-cache,no-store,max-age=0,must-revalidate

alexey@alexey-L380:~/Downloads$ curl  -i -X GET http://google.com
HTTP/1.1 301 Moved Permanently
Location: http://www.google.com/
Content-Type: text/html; charset=UTF-8
Date: Sat, 07 Sep 2019 15:02:30 GMT
Expires: Mon, 07 Oct 2019 15:02:30 GMT
Cache-Control: public, max-age=2592000
Server: gws
Content-Length: 219
X-XSS-Protection: 0
X-Frame-Options: SAMEORIGIN

<HTML><HEAD><meta http-equiv="content-type" content="text/html;charset=utf-8">
<TITLE>301 Moved</TITLE></HEAD><BODY>
<H1>301 Moved</H1>
The document has moved
<A HREF="http://www.google.com/">here</A>.
</BODY></HTML>


alexey@alexey-L380:~/Downloads$ curl  -i -X GET http://apple.com
HTTP/1.1 301 MOVED PERMANENTLY
Server: Apache 
Date: Sat, 07 Sep 2019 15:02:40 GMT
Location: https://www.apple.com/
Content-type: text/html
Connection: close

alexey@alexey-L380:~/Downloads$
```
> Что они вернули? Что содержится в теле ответа?
> > Все сайты ответили 302 или 301 кодом редиректа. google.com в теле ответа прислал html страницу со ссылкой на другую версию сайта

```
alexey@alexey-L380:~/Downloads$ curl  -i -X POST http://yandex.ru
HTTP/1.1 403 Forbidden
ETag: "5d715b5e-3077"
Content-Type: text/html; charset=utf-8
Date: Sat, 07 Sep 2019 15:03:22 GMT
Content-Length: 12407
X-Content-Type-Options: nosniff

<!DOCTYPE HTML>
<html lang="ru">
<head>
    <meta http-equiv="Content-Type" content="text/html;charset=UTF-8">
    <title>Яндекс</title>
    <link rel="shortcut icon" href="">
    <style type="text/css">
body, div, ul, table, tr, td, form, input {
    margin: 0;
    padding: 0
}
.........


alexey@alexey-L380:~/Downloads$ curl  -i -X POST http://apple.com
HTTP/1.1 301 MOVED PERMANENTLY
Server: Apache 
Date: Sat, 07 Sep 2019 15:04:02 GMT
Location: https://www.apple.com/
Content-type: text/html
Connection: close

alexey@alexey-L380:~/Downloads$ curl  -i -X POST http://google.com
HTTP/1.0 411 Length Required
Content-Type: text/html; charset=UTF-8
Referrer-Policy: no-referrer
Content-Length: 1564
Date: Sat, 07 Sep 2019 15:04:21 GMT

<!DOCTYPE html>
<html lang=en>
  <meta charset=utf-8>
  <meta name=viewport content="initial-scale=1, minimum-scale=1, width=device-width">
  <title>Error 411 (Length Required)!!1</title>
  <style>
    *{margin:0;padding:0}html,code{font:15px/22px arial,sans-serif}html{background:#fff;color:#222;padding:15px}body{margin:7% auto 0;max-width:390px;min-height:180px;padding:30px 0 15px}* > body{background:url(//www.google.com/images/errors/robot.png) 100% 5px no-repeat;padding-right:205px}p{margin:11px 0 22px;overflow:hidden}ins{color:#777;text-decoration:none}a img{border:0}@media screen and (max-width:772px){body{background:none;margin-top:0;max-width:none;padding-right:0}}#logo{background:url(//www.google.com/images/branding/googlelogo/1x/googlelogo_color_150x54dp.png) no-repeat;margin-left:-5px}@media only screen and (min-resolution:192dpi){#logo{background:url(//www.google.com/images/branding/googlelogo/2x/googlelogo_color_150x54dp.png) no-repeat 0% 0%/100% 100%;-moz-border-image:url(//www.google.com/images/branding/googlelogo/2x/googlelogo_color_150x54dp.png) 0}}@media only screen and (-webkit-min-device-pixel-ratio:2){#logo{background:url(//www.google.com/images/branding/googlelogo/2x/googlelogo_color_150x54dp.png) no-repeat;-webkit-background-size:100% 100%}}#logo{display:inline-block;height:54px;width:150px}
  </style>
  <a href=//www.google.com/><span id=logo aria-label=Google></span></a>
  <p><b>411.</b> <ins>That’s an error.</ins>
  <p>POST requests require a <code>Content-length</code> header.  <ins>That’s all we know.</ins>
alexey@alexey-L380:~/Downloads$

```

> Что они вернули? Что содержится в теле ответа?
> > Яндекс и Гугл ответили ошибкой 403 и 411 соответвенно. В теле их ответа есть html старница с соббщение об ошибке. apple.com опять ответил 302 кодом редиректа 

 
### 1.3. Работа с api сайта. Многие крупные сервисы предоставляют открытое api. Как правило, оно реализовано на подходе REST, но это необязательно. Такое api используется сторонними сервисами и приложениями, которые хотят воспользоваться услугами предоставляющего такое api сервиса. Рассмотрим такое api на примере сайта vk.com (при желании можно выбрать другой подходящий сервис).
 
#### 1.3.1. Зайдите на https://vk.com/dev/api_requests и посмотрите структуру запросов к данному api.
#### 1.3.2. Используя документацию (https://vk.com/dev/methods) выполните следующие задания (обратите внимание, запросы нужно отправлять не из предложенной на сайте формы, а как в предыдущем задании):
  * Получение ключа: `https://oauth.vk.com/authorize?client_id=7127124&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=wall&response_type=token&v=5.101`
  * Запрос ключа: `https://oauth.vk.com/blank.html#access_token=*******************&expires_in=86400&user_id=32126472`
  * Добавление ключа в переменные среды: `alexey@alexey-L380:~/Downloads$ VKTOKEN=*******************`

##### 1.3.2.1. Получите список всех факультетов МГТУ им. Н.Э.Баумана.
```json
alexey@alexey-L380:~/Downloads$ curl "https://api.vk.com/method/database.getFaculties?university_id=250&count=40&v=5.101&access_token=$VKTOKEN" | jq
  % Total    % Received % Xferd  Average Speed   Time    Time     Time  Current
                                 Dload  Upload   Total   Spent    Left  Speed
100  2020  100  2020    0     0   2881      0 --:--:-- --:--:-- --:--:--  2885
{
  "response": {
    "count": 20,
    "items": [
      {
        "id": 1031,
        "title": "Аэрокосмический факультет"
      },
      {
        "id": 1032,
        "title": "Факультет инженерного бизнеса и менеджмента"
      },
      {
        "id": 1033,
        "title": "Факультет информатики и систем управления"
      },
      {
        "id": 1034,
        "title": "Факультет машиностроительных технологий"
      },
      {
        "id": 1035,
        "title": "Факультет оптико-электронного приборостроения"
      },
      {
        "id": 1036,
        "title": "Приборостроительный факультет"
      },
      {
        "id": 1037,
        "title": "Радиотехнический факультет"
      },
      {
        "id": 1038,
        "title": "Факультет радиоэлектроники и лазерной техники"
      },
      {
        "id": 1039,
        "title": "Факультет ракетно-космической техники"
      },
      {
        "id": 1040,
        "title": "Факультет робототехники и комплексной автоматизации"
      },
      {
        "id": 1041,
        "title": "Факультет специального машиностроения"
      },
      {
        "id": 1042,
        "title": "Факультет фундаментальных наук"
      },
      {
        "id": 1043,
        "title": "Факультет энергомашиностроения"
      },
      {
        "id": 1044,
        "title": "Кафедра юриспруденции, интеллектуальной собственности и судебной экспертизы"
      },
      {
        "id": 1803,
        "title": "Факультет биомедицинской техники"
      },
      {
        "id": 1804,
        "title": "Факультет социально-гуманитарных наук"
      },
      {
        "id": 56430,
        "title": "Факультет лингвистики"
      },
      {
        "id": 56431,
        "title": "Физкультурно-оздоровительный факультет"
      },
      {
        "id": 2071503,
        "title": "Головной учебно-исследовательский и методический центр (ГУИМЦ)"
      },
      {
        "id": 2183736,
        "title": "Факультет военного обучения (Военный институт)"
      }
    ]
  }
}

```

##### 1.3.2.2. Получите свою аватарку.
```json
alexey@alexey-L380:~/Downloads$ curl "https://api.vk.com/method/users.get?user_ids=32126472&fields=photo_400&v=5.101&access_token=$VKTOKEN" | jq
  % Total    % Received % Xferd  Average Speed   Time    Time     Time  Current
                                 Dload  Upload   Total   Spent    Left  Speed
100   229  100   229    0     0   1761      0 --:--:-- --:--:-- --:--:--  1775
{
  "response": [
    {
      "id": 32126472,
      "first_name": "Алексей",
      "last_name": "Медведев",
      "is_closed": false,
      "can_access_closed": true,
      "photo_400": "https://sun9-17.userapi.com/c844618/v844618129/c0b93/fOiVWl7m1GY.jpg?ava=1"
    }
  ]
}
``` 
Ссылка на аватарку `https://sun9-17.userapi.com/c844618/v844618129/c0b93/fOiVWl7m1GY.jpg?ava=1`
##### 1.3.2.3. Ответьте на вопросы: какой код ответа присылается от api? Что содержит тело ответа? В каком формате и какой кодировке содержаться данные? Какой веб-сервер отвечает на запросы? Какая версия протокола HTTP используется?
```
alexey@alexey-L380:~/Downloads$ curl  -v "https://api.vk.com/method/users.get?user_ids=32126472&fields=photo_400&v=5.101&access_token=$VKTOKEN" | jq
  % Total    % Received % Xferd  Average Speed   Time    Time     Time  Current
                                 Dload  Upload   Total   Spent    Left  Speed
  0     0    0     0    0     0      0      0 --:--:-- --:--:-- --:--:--     0*   Trying 87.240.129.130...
* TCP_NODELAY set
* Connected to api.vk.com (87.240.129.130) port 443 (#0)
* (304) (OUT), TLS handshake, Client hello (1):
......
* Using HTTP2, server supports multi-use
* Connection state changed (HTTP/2 confirmed)
* Copying HTTP/2 data in stream buffer to connection buffer after upgrade: len=0
} [5 bytes data]
* Using Stream ID: 1 (easy handle 0x5611947c3580)
} [5 bytes data]
> GET /method/users.get?user_ids=32126472&fields=photo_400&v=5.101&access_token=**************** HTTP/2
> Host: api.vk.com
> User-Agent: curl/7.58.0
> Accept: */*
> 
{ [5 bytes data]
* Connection state changed (MAX_CONCURRENT_STREAMS updated)!
} [5 bytes data]
< HTTP/2 200 
< server: VK
< date: Sat, 07 Sep 2019 15:57:43 GMT
< content-type: application/json; charset=utf-8
< content-length: 229
< x-powered-by: PHP/3.20892
< cache-control: no-store
< strict-transport-security: max-age=86400
< 
{ [229 bytes data]
100   229  100   229    0     0   1940      0 --:--:-- --:--:-- --:--:--  1957
* Connection #0 to host api.vk.com left intact
{
  "response": [
    {
      "id": 32126472,
      "first_name": "Алексей",
      "last_name": "Медведев",
      "is_closed": false,
      "can_access_closed": true,
      "photo_400": "https://sun9-17.userapi.com/c844618/v844618129/c0b93/fOiVWl7m1GY.jpg?ava=1"
    }
  ]
}
```
> Какой код ответа присылается от api?
> > 200

> Что содержит тело ответа?
> > Json

> В каком формате и какой кодировке содержаться данные?
> > content-type: application/json; charset=utf-8

> Какой веб-сервер отвечает на запросы?
> > server: VK 

> Какая версия протокола HTTP используется?
> > HTTP/2

#### 1.3.3.  POST запросы проще отправлять с формы, встроенной в документацию api. Чтобы посмотреть, как выглядит запрос, можно воспользоваться панелью разработчика браузера (F12 в Chrome -> вкладка Network).
##### 1.3.3.1.  Отправьте запись на стену любому пользователю/группе и убедитесь, что она пришла. 
```bash
alexey@alexey-L380:~/Downloads$ curl  -X POST "https://api.vk.com/method/wall.post?mute_notifications=1&owner_id=32126472&v=5.101&access_token=$VKTOKEN"  --data-urlencode "message=$(date)" -q |jq
  % Total    % Received % Xferd  Average Speed   Time    Time     Time  Current
				 Dload  Upload   Total   Spent    Left  Speed
100   105  100    29  100    76    192    503 --:--:-- --:--:-- --:--:--   695
{
  "response": {
    "post_id": 1184
  }
}
```
##### 1.3.3.2.  Ответьте на вопрос: каким образом передаются данные от пользователя к серверу в POST-запросах?
```
alexey@alexey-L380:~/Downloads$ curl -v -d "mute_notifications=1&owner_id=32126472&v=5.101&access_token=$VKTOKEN&message=Hi" https://api.vk.com/method/wall.post 
Trying 95.213.11.163...
* TCP_NODELAY set
* Connected to api.vk.com (95.213.11.163) port 443 (#0)

***** TLS handshake, Client hello (1) *****

* Using HTTP2, server supports multi-use
* Connection state changed (HTTP/2 confirmed)
* Copying HTTP/2 data in stream buffer to connection buffer after upgrade: len=0
* Using Stream ID: 1 (easy handle 0x55ceac2b7580)
> POST /method/wall.post HTTP/2
> Host: api.vk.com
> User-Agent: curl/7.58.0
> Accept: */*
> Content-Length: 156
> Content-Type: application/x-www-form-urlencoded
> 
* Connection state changed (MAX_CONCURRENT_STREAMS updated)!
* We are completely uploaded and fine
< HTTP/2 200 
< server: VK
< date: Sat, 07 Sep 2019 18:41:25 GMT
< content-type: application/json; charset=utf-8
< content-length: 29
< x-powered-by: PHP/3.20892
< cache-control: no-store
< strict-transport-security: max-age=86400
< 
* Connection #0 to host api.vk.com left intact
{"response":{"post_id":1195}}a
```
Данные передаются от пользователя в формате application/x-www-form-urlencoded внутри тела запроса. При Get запросе данных полей нету
```
Content-Length: 156
Content-Type: application/x-www-form-urlencoded
```

```
alexey@alexey-L380:~/Downloads$ curl -v  -X GET "https://api.vk.com/method/wall.post?mute_notifications=1&owner_id=32126472&v=5.101&access_token=$VKTOKEN&message=HIIII"
Note: Unnecessary use of -X or --request, GET is already inferred.
*   Trying 93.186.225.192...
* TCP_NODELAY set

***** TLS handshake, Client hello (1) *****

* Using HTTP2, server supports multi-use
* Connection state changed (HTTP/2 confirmed)
* Copying HTTP/2 data in stream buffer to connection buffer after upgrade: len=0
* Using Stream ID: 1 (easy handle 0x55c9a41a1580)
> GET /method/wall.post?mute_notifications=1&owner_id=32126472&v=5.101&access_token=***********************&message=HIIII HTTP/2
> Host: api.vk.com
> User-Agent: curl/7.58.0
> Accept: */*
> 
* Connection state changed (MAX_CONCURRENT_STREAMS updated)!
< HTTP/2 200 
< server: VK
< date: Sat, 07 Sep 2019 18:36:12 GMT
< content-type: application/json; charset=utf-8
< content-length: 29
< x-powered-by: PHP/3.20892
< cache-control: no-store
< strict-transport-security: max-age=86400
< 
* Connection #0 to host api.vk.com left inta
{"response":{"post_id":1196}}
```
