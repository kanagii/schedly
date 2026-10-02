# Schedly

A minimal, dark-themed schedule tracker built with Blazor WebAssembly (.NET 10) and Tailwind CSS v4.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) — check with `dotnet --version`
- [Node.js](https://nodejs.org/) (for the Tailwind CLI) — check with `node --version`

## Setup

Clone the repo and install the Tailwind CLI:

```bash
git clone https://github.com/kanagii/schedly.git
cd schedly
npm install
```

## Running the project

To run the app, open the terminal and type:
```bash
dotnet watch
```

Then open **http://localhost:5050/** in a browser.


## Routes

| Route | Page |
|---|---|
| `/` | Landing page (logged-out marketing page) |
| `/login` | Sign in |
| `/register` | Create an account |
| `/home` | Schedule dashboard (Today / Week / Events) |
| `/reviews` | Ratings & comments page |

## Project structure

```
Pages/       Routable pages (Login, Register, Home, Reviews, Landing, ...)
Layout/      Shared layouts (AuthLayout, EmptyLayout, MainLayout)
wwwroot/
  css/
    input.css      Tailwind entry point (@import "tailwindcss";)
    tailwind.css   Generated output — do not hand-edit, Tailwind overwrites it
    app.css        Blazor's own base styles (loading spinner, error banner) — keep separate from Tailwind output
  images/      Logos and icons
```
