# Argenta - A Personal Finance Application

## Description

**Argenta** is a personal finance web application that allows the user to plan their finances for savings or specific goals. Using this application, the user will be able to track their income, expenditures, and savings. The user will also be able to get the specifics in each of the said categories like debt, money saved, investments, expenses, and tracking goals using internal API for calculating data and external API for getting investment prices. Lastly, the user will be able to budget their income by specifying the percentage in each entry. The main point of this application is to be able to plan your finances using a single program instead of using multiple web applications.

## Features

The following are the specific features that Argenta has to be help the user plan and track their finances in multiple ways:

- The ability to save progress with a **personal GUID** generated for every new access to the website and means of retrieving previous data by inputting previous GUID.
- **Budgeting** section where the user can create different budgets with different total amounts with the added ability to display a pie chart of the calculated prices and percentages inputted by the user.
- **Transactions** section where the user can record the input and output of their transactions in order to track expenses and assets with the capacity of generating a line chart to visually track the highs and lows of the user’s transactions.
- **Goal Tracking** section where the user can create goals that they want to achieve, record each payment and chart their payments against the generated Future Values that the goal value will accrue due to APR.
- **Investments** section where the user can create an investment bundle and track each investment entry. In addition, the user can generate the chart of the purchase price against the current price of each investment.

## Tools Used

### Frontend

- [Blazor WebAssembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) - Component-based, Interactive Web UI framework
- [CSS3](https://www.w3.org/TR/CSS/#css) - Custom styling
- [Bootstrap 5](https://getbootstrap.com/) - CSS framework for building responsive, mobile-first websites
- [FontAwesome 5](https://fontawesome.com/) - Icon library and toolkit

### Backend

- [ASP.NET Core Web API](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0) - Web framework that is a part of ASP.NET Core for creating REST APIs
- [Microsoft Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - A lightweight, extensible Object-Relational Mapper
- [Microsoft SQL Server](https://www.microsoft.com/en-ca/sql-server/sql-server-2019) - Relational database management system

### External API

- [AlphaVantage](https://www.alphavantage.co/) - JSON API that provides financial market data

## Asset Sources

- [unDraw](https://undraw.co/) - high-quality vector graphics

## Future Improvements

- Better modularity since it was done in a rush.
- Fixing the the goal calculation algorithm in Goal Tracking to properly track the interest of the Goal.
- Proper authentication of a rush job using auto-generated UUIDs using [ASP.NET Core Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio).
- Either alternative API or subscribe to the premium version to properly track the investments since there's a 5 request/5 minutes limit in AlphaVantage API.
- Fix the bug in the ROI calculation in the Investment Entry Chart modal.