# Juego Roll-a-Ball

Este proyecto consiste en un pequeño videojuego desarrollado con **Unity**, basado en el clásico *Roll-a-Ball*.  
El objetivo del juego es controlar una esfera y recoger una serie de **collectibles (pickups)** dentro de un tiempo limitado, a lo largo de varios niveles.

Durante el juego, el jugador deberá:
- Mover la esfera por el escenario.
- Recoger todos los pickups del nivel.
- Evitar a un enemigo que provoca la derrota al entrar en contacto.
- Superar el límite de tiempo establecido.

El juego consta de **tres niveles**.  
Una vez completados todos con éxito, el juego finaliza mostrando la pantalla de victoria.

---

## Getting Started

A continuación se describen los requisitos mínimos recomendados para poder **desarrollar y ejecutar correctamente** el proyecto utilizando Unity.

### Requisitos de Hardware

- **Procesador:** CPU x64 con soporte SSE2  
- **Memoria RAM:** mínimo 8 GB (16 GB recomendado)  
- **Tarjeta gráfica:** Compatible con DirectX 10 / 11 / 12  
- **Almacenamiento:** Al menos 30 GB de espacio libre (SSD recomendado)  
- **Pantalla:** Resolución mínima 1366×768  

---

## Prerequisites

El software necesario para trabajar con este proyecto es el siguiente:

- **Unity Hub**
- **Unity Editor** (versión utilizada: **Unity 6.3 LTS**)
- **Visual Studio Community 2022**, con la carga de trabajo:
  - *Desarrollo de juegos con Unity*

---

## Installing

Para acceder y trabajar con el proyecto, sigue los pasos indicados a continuación:

1. Descarga el repositorio desde GitHub:  
   https://github.com/asuassau/Roll-a-ball.git

2. Extrae el archivo ZIP descargado.

3. Abre **Unity Hub**.

4. Accede a la pestaña **Projects** y pulsa:
  Add → Add project from disk

5. Selecciona la carpeta del proyecto previamente descomprimida.

Una vez realizado este proceso, el proyecto se abrirá en el editor de Unity y estará listo para su ejecución o modificación.

---

## Running the Game

Para ejecutar el juego desde el editor de Unity:

1. Abre la escena inicial del proyecto (menú principal o primer nivel).
2. Pulsa el botón **Play** en la parte superior del editor.
3. Controla la esfera utilizando:
- Teclas de movimiento configuradas (WASD / flechas).
- Barra espaciadora para saltar.
4. Recoge todos los pickups antes de que se agote el tiempo y evita al enemigo.

---

## Gameplay Features

- Movimiento físico mediante Rigidbody.
- Sistema de salto controlado.
- Contador de tiempo por nivel.
- Sistema de niveles.
- Pantallas de victoria y derrota.
- Enemigo con comportamiento de persecución.
- Interfaz gráfica mediante UI (TextMeshPro).

---

## Built With

- **Unity 6.3 LTS** – Motor de desarrollo del videojuego  
- **C#** – Lenguaje de programación  
- **Visual Studio Community 2022** – Entorno de desarrollo  
- **TextMeshPro** – Sistema de texto para la interfaz gráfica  

---

## Versioning

- **Versión:** 1.0  

---

## Authors

- **Alejandro Jesús Suárez Saavedra**

---

## License

Este proyecto ha sido desarrollado con fines **educativos y de aprendizaje**, por lo que no cuenta con una licencia específica.  
Su uso es libre para fines académicos o formativos.

---

## Acknowledgments

Este proyecto ha sido desarrollado gracias a los conocimientos adquiridos y las herramientas proporcionadas en la asignatura **Programación de Gráficos y Lenguajes (PGL)**, perteneciente al módulo de **Desarrollo de Aplicaciones Multiplataforma (DAM)**, cursado en el **IES El Rincón**.
