**FinTrack** — веб-приложение для управления личными финансами, доходами и расходами. Финансовый кошелек.

## О проекте
FinTrack — это индивидуальный образовательный проект, ориентированный на закрепление практики разработки веб-приложений с использованием технологий Microsoft (.NET 8, ASP.NET Core MVC, Entity Framework). Проект охватывает все этапы жизненного цикла ПО: проектирование, реализация, тестирование и документирование.

**FinTrack** — это веб-приложение на базе **ASP.NET Core MVC**, предназначенное для удобного учёта личных доходов и расходов, анализа финансов, постановки целей и формирования отчётов. Проект разработан с нуля с полным циклом: проектирование, реализация, тестирование и оформление UI/UX.

**Период разработки:** Декабрь 2024 — Май 2025 

**Технологии:**

- ASP.NET Core MVC

- C#

- Entity Framework

- HTML/CSS


**Аутентификация:** ASP.NET Identity (Identity.EntityFrameworkCore, Identity.UI)


### Основные возможности приложения:

### Главная страница (Dashboard)
Центр управления финансами пользователя. Отображает:
- Общий баланс
- Доходы и расходы за текущий месяц
- Виджеты для быстрого добавления транзакций (`+Widget`)
- Уведомления о последних действиях и важных событиях

### Категории (Categories)
Позволяет:
- Создавать, редактировать и удалять категории доходов и расходов
- Группировать транзакции для удобного анализа

### Транзакции (Transactions)
Функция добавления и управления:
- Доходов (зарплата, подработка, подарки и т.д.)
- Расходов (продукты, транспорт, развлечения и др.)
- Фильтрация по дате, категории и типу

### Аналитика (Analytics)
Глубокий анализ финансового поведения:
- Статистика по категориям за месяц
- Поисковик для фильтрации данных
- Экспорт графиков (визуализация расходов и доходов)

### Цели (Goals)
Планирование и контроль финансовых целей:
- Постановка целей (накопления, покупки и т.п.)
- Отслеживание прогресса
- Статистика: количество целей, типы, средний прогресс

### Отчёты (Reports)
Формирование детальных отчётов:
- Ежемесячная статистика
- Сравнение периодов
- Визуализация данных в виде диаграмм

### Профиль и настройки (Profile / Settings)
Управление учётной записью:
- Просмотр email и имени
- Смена пароля
- Выход из аккаунта
- Переключение темы интерфейса: светлая / тёмная

---

## Дополнительные функции
**Уведомления** — показывают последние действия (например, "Добавлен расход: 3 500 ₽")  
**Системные сообщения** — информируют о достижении целей   
**Адаптивный интерфейс** — поддержка мобильных устройств  
**Кастомные шаблоны** — `_Layout.cshtml`, `_SideBar.cshtml`, `_LoginLayout.cshtml`  
**JS-валидация** — jQuery Validate + Unobtrusive Validation


---

## Как запустить проект локально

### Предварительные требования
- [.NET 8 SDK](https://dotnet.microsoft.com/download) (или выше)
- [Visual Studio](https://visualstudio.microsoft.com/) (рекомендуется) или VS Code
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) или SQL Server Express
- Git (для клонирования)

### Шаги:

1. **Склонируйте репозиторий (если нужно):**
   ```bash
   git clone https://github.com/ваш-ник/FinTrack.git
   cd FinTrack
   ```

2. **Откройте решение:**
   - Запустите файл `FinTrack.sln` в Visual Studio, или
   - Используйте CLI: `dotnet build`

3. **Настройте строку подключения в `appsettings.json`:**
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=FinTrackDb;Trusted_Connection=true;TrustServerCertificate=true;"
   }
   ```
   > Если используете другой сервер (например, `(localdb)\\MSSQLLocalDB`), измените строку соответственно.

4. **Примените миграции EF:**
   Убедитесь, что вы в папке с `FinTrack.csproj`, затем выполните:
   ```bash
   dotnet ef database update
   ```
   Это создаст базу данных и все таблицы (включая Identity, Transactions, Goals и др.).

5. **Запустите приложение:**
   ```bash
   dotnet run
   ```
   Или нажмите **F5** в Visual Studio.

6. **Откройте в браузере**
   
---

## 📁 Структура проекта (основные файлы)

```
FinTrack/
├── FinTrack.sln                          // Решение Visual Studio
├── Program.cs                            // Точка входа (.NET 8)
├── appsettings.json                      // Конфигурация приложения
├── appsettings.Development.json          // Настройки для разработки
│
├── Data/
│   ├── ApplicationDbContext.cs           // Контекст для основных сущностей
│   ├── AuthDbContext.cs                  // Контекст для Identity
│   ├── Migrations/                       // Миграции EF
│   │   ├── 20250514231236_InitialCreate.cs
│   │   ├── 20250515000939_AddAnalyticsAndReports.cs
│   │   └── ...                           // Последовательные миграции
│   ├── ApplicationDbContextModelSnapshot.cs
│   └── AuthDbContextModelSnapshot.cs
│
├── Models/
│   ├── ApplicationUser.cs                // Расширение пользователя Identity
│   ├── Category.cs                       // Модель категории
│   ├── Transaction.cs                    // Модель транзакции
│   ├── Goal.cs                           // Модель финансовой цели
│   ├── Reports.cs                        // Модель отчётов
│   ├── Analytics.cs                      // Модель аналитики
│   ├── SettingsViewModel.cs              // DTO для настроек
│   └── ErrorViewModel.cs
│
├── Controllers/
│   ├── DashboardController.cs
│   ├── TransactionController.cs
│   ├── CategoryController.cs
│   ├── AnalyticsController.cs
│   ├── GoalsController.cs
│   ├── ReportsController.cs
│   ├── SettingController.cs
│   ├── SearchController.cs
│   ├── HomeController.cs
│   └── AccountController.cs (внутри Pages/Account)
│
├── Pages/
│   ├── Account/
│   │   ├── Login.cshtml
│   │   ├── Register.cshtml
│   │   └── ...                           // Страницы Identity.UI
│   │
│   ├── Shared/
│   │   ├── _Layout.cshtml                // Основной шаблон
│   │   ├── _SideBar.cshtml               // Навигационная панель
│   │   ├── _LoginLayout.cshtml           // Макет для входа
│   │   ├── _ValidationScriptsPartial.cshtml
│   │   └── _ViewImports.cshtml
│   │
│   ├── Dashboard/
│   │   └── Index.cshtml
│   ├── Transaction/
│   │   └── AddOrEdit.cshtml
│   ├── Category/
│   │   └── Index.cshtml
│   ├── Analytics/
│   │   └── Index.cshtml
│   ├── Goals/
│   │   └── Index.cshtml
│   ├── Reports/
│   │   └── ReportView.cshtml
│   ├── Setting/
│   │   └── Index.cshtml
│   └── Privacy.cshtml
│
├── wwwroot/
│   ├── css/
│   │   ├── site.css
│   │   ├── themes.css                  // Поддержка тёмной/светлой темы
│   │   └── bootstrap/*.css             // Bootstrap 5
│   ├── js/
│   │   ├── site.js
│   │   ├── theme.js                    // Переключение темы
│   │   └── jquery/*.js                 // jQuery + Validation
│   └── lib/
│       └── bootstrap/                  // Bootstrap файлы
└── README.md
```

---

## Скриншоты:

   <img width="1018" height="512" alt="image" src="https://github.com/user-attachments/assets/a7d69fa3-7781-480f-b3c5-9b05915ec687" />

   **Главная страница Пользователя**

   Главная страница — это центр управления финансами пользователя. Она предоставляет краткий обзор текущего состояния бюджета, включая общий доход, расходы и баланс. На этой странице отображаются последние транзакции, активные цели и графики, которые помогают быстро оценить финансовое состояние.


   
   <img width="1021" height="373" alt="image" src="https://github.com/user-attachments/assets/65ad7234-fdd2-42e8-893e-91c45ffbc1cb" />
   
   **Страница Категории**

   Страница для создания, редактирования и удаления категорий. Категории позволяют группировать транзакции по типам, что упрощает анализ данных.



   <img width="1019" height="462" alt="image" src="https://github.com/user-attachments/assets/21c9f808-6532-4c54-b8cd-9a6c1bdd8960" />
   
   **Страница Транзакции**

   Страница для фиксирования новых транзакций (доходов или расходов). Пользователь может указать сумму, категорию, дату и описание.



   <img width="1023" height="526" alt="image" src="https://github.com/user-attachments/assets/6f006c60-2d71-4d5c-b210-b2c6e1159dd6" />
   
   **Страница Аналитика**

   Страница для глубокого анализа финансовых данных. Здесь пользователь может видеть статистику по доходам, расходам и другим параметрам за выбранный период.



   <img width="1033" height="545" alt="image" src="https://github.com/user-attachments/assets/e9e6017a-1c05-4a1b-80e1-b7056b40f36a" />
   
   **Страница Цели**

   Страница для планирования и отслеживания финансовых целей. Пользователь может создавать цели, такие как накопление определенной суммы или снижение расходов.



   <img width="1009" height="505" alt="image" src="https://github.com/user-attachments/assets/3157aeef-450c-4803-9f72-0caa9d810465" />
   
   **Страница Отчетов**

   Страница для просмотра финансовой статистики за выбранный период. Отчеты могут быть экспортированы в формате PDF.



   <img width="823" height="516" alt="image" src="https://github.com/user-attachments/assets/8a7a65ce-2c7d-46e5-a7a3-82de9cb51907" />
   
   **Страница Настройки**

   Страница для управления учетной записью пользователя. Здесь можно изменить личные данные, настройки безопасности и предпочтения.







   *В FinTrack включает создание интуитивно понятного и функционального интерфейса для каждой страницы. Главная страница предоставляет общий обзор финансов, а специализированные страницы (например, «Добавление транзакций», «Анализ данных» и «Постановка целей») позволяют пользователям эффективно управлять своими финансами. Все страницы разработаны с учетом удобства использования и визуальной привлекательности.*


   





