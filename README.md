# Inventory Management System

## Overview

The **Inventory Management System** is a Windows Forms application designed to help small retail stores efficiently manage their inventory. The system provides essential features to track products, manage stock levels, record transactions, and generate reports, making it easier for store owners to maintain accurate inventory records.

## Features

### 1. Product Management
- **Product List:** Add, edit, and maintain a list of products with details such as name, description, and selling price.
- **Categorization:** Organize products into categories for better management.

### 2. Inventory Tracking
- **Stock Levels:** Display the current quantity of each product in stock.
- **Automatic Updates:** Automatically update stock levels based on purchase and sales transactions.

### 3. Transaction Recording
- **Record Transactions:** Log all inventory changes, including purchases and sales, with details like date, product, quantity, and optional notes.

### 4. Reporting
- **Inventory Status:** View the current status of inventory, including stock levels and total inventory value.
- **Basic Reports:** Generate reports that show stock levels and recent transactions.
- **Category-wise Reports:** Create reports that display the balance and total value of products in each category.

### 5. Search and Filter
- **Product Search:** Search for products by name or description.
- **Filter by Category:** Filter products based on their assigned categories.

## Overall Process

1. **Add Products:** Enter product details into the system to create a comprehensive product list.
2. **Record Purchases:** Log purchase transactions to add new stock to the inventory.
3. **Record Sales:** Record sales transactions to update the inventory and reflect sold products.
4. **Generate Reports:** View updated inventory status and generate reports as needed.

## Technical Details

- **Platform:** Windows Forms application developed in C#.
- **Data Management:** Uses Entity Framework Core for database operations.
- **Database:** Microsoft SQL Server is used for storing and managing data.
- **Asynchronous Programming:** Implemented to enhance performance and responsiveness.
- **Querying:** LINQ is used for efficient data querying and manipulation.
