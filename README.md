# financial-tranx-parser
Simple text based parser that import banks transactions in various formats and automatically categorize and summarize with a rolling time range.

Orginally this started as a quick and dirty application to solve a simple problem; be able to parse a bunch of csv files for specific key words to categorize expenses e.g. as groceries, gas, etc.  Then summarize each category on a specific day of the week to generate a weekly total cost per catgegory.  The initial challenges were that each bank has it's own order and sometimes format for data so a custom specification needed to be defined for each bank / file format.  For example some banks just output the transaction amount while others also output the ongoing balance.  Additionally, banks will change their export format slightly over time as they decide to add or remove columns or maybe even output values slightly differently; maybe values are always quoted and have comma separated thousands indicators and maybe they just output a raw value with 2 decimal places.
The **ParseAndFilterTransactions** project represents the simple C# WinForm application that was written to solve this problem and as it was evolved over time to better accominate the changes.
The **QuickHomeExpenseSummarizer** project was started from scratch in an effort to actually create a simple product that other people could use.  It was also an opertunity to use two technologies for the first time:
1) **Entity Framework Core** to store user configurations / options in a SQL lite database
2) **Community Toolkit MVVM** - to create view models with less boiler plate coding.

