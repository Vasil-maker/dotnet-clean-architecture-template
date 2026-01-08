.NET Clean Architecture Template
Готовый к использованию шаблон для создания микросервисов на .NET с архитектурой Clean Architecture.

 Что создаёт шаблон
При использовании команды dotnet new Capi -n MyProject создаётся следующая структура:

MyProject

README.md                  Инструкции по проекту
MyProject.API/             Слой Web API
MyProject.Application/     Бизнес-логика
MyProject.Domain/          Доменные модели
MyProject.Infrastructure/  Данные и внешние сервисы

 Быстрый старт

1. Добавить источник GitHub Packages
Создайте Personal Access Token на GitHub с правами
read:packages и выполните:

Конкретный пример
dotnet nuget add source https://nuget.pkg.github.com/iksergey/index.json \
  --name github-iksergey \
  --username iksergey \
  --password PCH2Y60YqR7qg8lfyZcjCP3BQ4yr \
  --store-password-in-clear-text

2. Установить шаблон
dotnet new install iksergey.cleanarchitecture.template

3. Использовать шаблон
 Создать новый проект
dotnet new Capi -n MyMicroservice

 Перейти в проект и запустить
cd MyMicroservice
dotnet build
dotnet run --project MyMicroservice.API

 Управление шаблоном
Проверить установку:
dotnet new list

Обновить шаблон:
dotnet new install iksergey.cleanarchitecture.template --force

Удалить шаблон:
dotnet new uninstall iksergey.cleanarchitecture.template

Удалить источник:
dotnet nuget remove source github-iksergey

 Дополнительные команды
 Посмотреть все источники NuGet
dotnet nuget list source

 Публикация новых версий (для автора)
Внесите изменения в шаблон:

Отредактируйте файлы в working/content/Capi/
Обновите PackageVersion в Template.csproj
Закоммитьте и создайте тег:

git add .
git commit -m "Update template: добавлена новая функциональность"
git push origin main

 Создать и запушить тег версии
git tag v1.0.0
git push origin v1.0.0

Автоматическая публикация
GitHub Actions автоматически опубликует пакет в GitHub Packages при создании тега.

Проверить публикацию: Actions → статус workflow, Packages → новая версия.