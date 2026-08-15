# Inversiones XTB
# 📈 JXP Capital - Financial Portfolio Tracker

Una aplicación de escritorio desarrollada en C# para la gestión de portafolios de inversión y el seguimiento del mercado de valores en tiempo real. 

Este proyecto fue construido con un enfoque en la arquitectura de software limpia, el manejo seguro de bases de datos locales y el consumo de APIs financieras asíncronas.

## ✨ Características Principales

* **Mercado en Vivo:** Conexión en tiempo real a la API de Yahoo Finance para obtener precios actualizados de acciones del sector tecnológico y de infraestructura (NVDA, MSFT, GOOG, CAT, etc.).
* **Gestión de Base de Datos Local:** Registro seguro de transacciones de compra y venta utilizando SQLite, asegurando que los datos del usuario se mantengan privados y locales.
* **Dashboard Financiero:** Cálculo automático de métricas clave como:
  * Capital Invertido
  * Valor Actual del Portafolio
  * Ganancia Neta (Sombreado condicional verde/rojo)
  * Porcentaje de Rentabilidad (ROI)
* **Interfaz de Usuario Premium (UI):** Diseño moderno estilo "Dark Mode / Light Mode" utilizando la librería MaterialSkin, alejándose de los diseños clásicos de Windows Forms para ofrecer una experiencia de nivel comercial.
* **Control de Concurrencia:** Lógica asíncrona (`async/await`) y manejo de temporizadores para evitar cuellos de botella durante las peticiones a la red.

## 🛠️ Tecnologías y Herramientas

* **Lenguaje:** C# (.NET Framework)
* **Interfaz Gráfica:** Windows Forms, MaterialSkin
* **Base de Datos:** SQLite
* **Consumo de API:** `HttpClient`, JSON Parsing (`Newtonsoft.Json`)
* **Gráficos:** `System.Windows.Forms.DataVisualization.Charting`

## 🚀 Instalación y Uso

1. Clona este repositorio en tu máquina local:
   ```bash
   git clone [https://github.com/TuUsuario/JXP-Capital-App.git](https://github.com/TuUsuario/JXP-Capital-App.git)
   Abre la solución .sln en Visual Studio.

Restaura los paquetes NuGet si es necesario (Newtonsoft.Json, MaterialSkin, System.Data.SQLite).

Compila y ejecuta la aplicación (F5).

Nota: La aplicación creará automáticamente el archivo de base de datos portafolio.db en la carpeta binaria durante su primera ejecución.

👨‍💻 Autor
Jeyson Ariel Palles Castro

Estudiante de Ingeniería en Software y Sistemas - Universidad Técnica del Norte

Este proyecto es parte de mi portafolio de desarrollo de software académico y personal.
