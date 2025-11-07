
# 🍺 Projekt Piwowar

**Piwowar** is a Windows desktop application built with **C# / .NET (WinForms)** that helps homebrewers manage ingredients, create beer recipes, and track brewing batches.

The application supports full ingredient stock tracking (grains, hops, yeast), recipe creation, and brewing batch logging — including automatic beer parameter calculations:

- °BLG (extract)
- IBU (bitterness — Tinseth formula)
- EBC (beer color estimate)

---

## 🚀 Features

- 🏪 **Ingredient inventory management** (malt, hops, yeast)
- 🧾 **Recipe builder** — create and edit beer brewing recipes
- 🍺 **Batch creation ** — generate brewing batches from recipes
- 💾 **Persistent data storage** — all items remain saved between sessions
- 📋 **List views** for recipes and batches
- 🧮 Automatic brewing calculations:
  - °BLG (extract)
  - IBU (Tinseth bitterness formula)
  - EBC (beer color estimation)

---

## 🧠 Architecture

```
📁 Piwowar
 ├── Models/
 │    ├── Malt.cs            // Grain ingredient
 │    ├── Hop.cs             // Hop ingredient (with alpha acid values)
 │    ├── Yeast.cs           // Yeast ingredient
 │    ├── Recipe.cs          // Beer recipe
 │    └── Batch.cs           // Brewing batch (Warka)
 │
 ├── Services/
 │    ├── BlgCalculator.cs   // Extract / gravity calculations
 │    ├── IbuCalculator.cs   // Bitterness calculations (Tinseth)
 │    └── EbcCalculator.cs   // Color calculations
 │
 └── Forms/
      ├── RecipeForm.cs      // UI: recipe builder
      ├── BatchForm.cs       // UI: batch creation
      └── InventoryForm.cs   // UI: ingredient storage
```

---

## 🛠️ Technologies Used

- **C# / .NET (WinForms)**
- **OOP (Object-Oriented Programming)**
- Visual Studio 2022
- Manual local storage (data persistence)

---

## ⚙️ How to Run

1. Clone the repository:

```sh
git clone https://github.com/JanKolodziej/Aplikacja-Piwowarska.git
```

2. Open the solution in **Visual Studio 2022**
3. Build and run (`F5`)

---

## 🧩 Future Improvements

- 📊 Add fermentation BLG tracking with charts
- 💾 Save data using SQLite / LiteDB
- 📄 Export recipes to PDF
- 🧹 Full refactor to 3‑layer architecture (UI / Core / Data)

---

## 👤 Author

**Jan Kołodziej**  
💼 .NET C# Developer  
📧 jankolodziej@outlook.com  
🔗 https://www.linkedin.com/in/jan-kolodziej-krk/

---

> This project was created as part of learning C# and building a real application for portfolio purposes.
