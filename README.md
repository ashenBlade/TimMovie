# 🎊 TimMovie 🎊 Сайт для просмотра фильмов 🎞️
За основу был взят сайт ivi. Фактически данная система состоит из двух сайтов (разрабатывались они как два отдельных проекта с общей бд): пользовательский и админский. 
Пользовательская часть для пользователя и сотрудника техподдержки. Админская частью для админа.

## Основные возможности
### Пользователь
Возможности в пользовательской части: 
- Регистрация пользователя через почту или ВКонтакте;
- Просмотр популярных фильмов по определенным жанрам;
- Фильтрация по жанру, стране, году и рейтингу. Дополнительно сортировка по названию, просмотрам, рейтингу, популярности и году;
- Глобальный поиск по фильмам, актерам и режиссерам;
- Просмотр страницы со всеми оценками фильмов, которые делал пользователь;
- Просмотр страницы актера или режиссера с информацией о нем;
- Добавление фильма в "Посмотреть позже";
- Оценки фильма по 10 бальной шкале;
- Добавление комментария к фильму;
- Редактирование своего профиля;
- Посещение профиля другого пользователя. Просмотр всех его оценок фильмов;

Также на сайте присутствует система подписок. Пользователь не сможет посмотреть фильм, если у него нет подписки, которая включает в себя данный фильм. В подписке указано, какие фильмы и жанры  входят в подписку. Настоящую покупку совершить нельзя, есть имитация покупки. 

Еще одна возможность пользователя - это обращение в чат техподдержки. 

### Техподдержка 
Сотрудник техподдержки авторизуется через ту же форму, что и пользователь. У него появляется дополнительная вкладка для чата с пользователем. Для того чтобы выйти на смену, сотруднику нужно нажать на соответствующую кнопку, после чего его автоматически будет подключать к пользователю, который написал в техподдержку.
 
### Админ
Администратор по сути может производить CRUD операции с контентом, который есть на пользовательском сайте.
Контент, который может менять админ:
- Фильмы
- Банеры
- Актеры и режиссеры
- Жанры 
- Подписки

Также у админа есть возможность изменять роль пользователя и добавлять или удалять его подписки. 

## Api сайта 
У нашего сайта также есть открытое api.  Можно достать большую часть информации о контенте, который находится на сайте.

## Архитектура
![Архитектура](/Docs/architecture.png)
@startuml
title TimMovie - Containers

left to right direction

!include https://raw.githubusercontent.com/plantuml-stdlib/C4-PlantUML/master/C4.puml
!include https://raw.githubusercontent.com/plantuml-stdlib/C4-PlantUML/master/C4_Context.puml
!include https://raw.githubusercontent.com/plantuml-stdlib/C4-PlantUML/master/C4_Container.puml

Person(Client, "Client", "", $tags="")
Person(Admin, "Admin", "", $tags="")
Person(SupportEmployee, "Support Employee", "", $tags="")
Person(AnyApiUser, "Any Api User", "", $tags="")
System(Email, "Email", "", $tags="")

System_Boundary("TimMovie_boundary", "TimMovie") {
  Container(TimMovie.SPAAdmin, "SPA Admin", "React on Type Script", $tags="")
  Container(TimMovie.WebApiAdmin, "Web Api Admin", "Nest JS on Type Script", $tags="")
  Container(TimMovie.AuthService, "Auth Service", "ASP Net Core on F#", $tags="")
  Container(TimMovie.OpenSiteWebApi, "Open Site Web Api", "ASP Net Core on F#", $tags="")
  Container(TimMovie.Database, "Database", "Postgres", $tags="")
  Container(TimMovie.WebAppClient, "Web App Client", "ASP Net Core on C#", $tags="")
}

Rel_D(Admin, TimMovie.SPAAdmin, "", $tags="")
Rel_D(TimMovie.SPAAdmin, TimMovie.WebApiAdmin, "", $tags="")
Rel_D(TimMovie.WebApiAdmin, TimMovie.AuthService, "Authentication", $tags="")
Rel_D(TimMovie.SPAAdmin, TimMovie.AuthService, "Authentication", $tags="")
Rel_D(TimMovie.WebAppClient, TimMovie.AuthService, "Authentication", $tags="")
Rel_D(TimMovie.OpenSiteWebApi, TimMovie.AuthService, "Authentication", $tags="")
Rel_D(AnyApiUser, TimMovie.OpenSiteWebApi, "Getting data through API of site", $tags="")
Rel_D(TimMovie.WebAppClient, TimMovie.Database, "", $tags="")
Rel_D(TimMovie.WebApiAdmin, TimMovie.Database, "", $tags="")
Rel_D(TimMovie.OpenSiteWebApi, TimMovie.Database, "", $tags="")
Rel_D(TimMovie.WebAppClient, Email, "", $tags="")
Rel_D(Email, Client, "Sending mail confirmation message", $tags="")
Rel_D(SupportEmployee, TimMovie.WebAppClient, "", $tags="")
Rel_D(Client, TimMovie.WebAppClient, "", $tags="")

SHOW_LEGEND()
@enduml

## Используемые технологии
### Пользовательская часть
- **ASP Net Core 6** на C# с использованием Razor для рендеринга страниц на стороне сервера;
- **SignalR** для чата техподдержки;
- **EF Core**
-  **ASP Net Core Identity**

### Админская часть
- **React** на Type Script
- **Nest Js** на Type Script
- **TypeORM**

### Api сайта
- **ASP Net Core 6** на F#

### Общее
- **OpenIddict**
