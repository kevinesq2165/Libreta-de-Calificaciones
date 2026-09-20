# Laboratorio - Libro de Calificaciones en C#

Ejercicio desarrollado para practicar el uso de **estructuras repetitivas en C#**, específicamente dos formas de controlar la repetición de un procedimiento: mediante un **contador** y mediante un **valor centinela**.

**Herramientas de la Programación Aplicada III (.NET)**  
**Universidad Tecnológica de Panamá - Facultad de Ingeniería en Sistemas**

**Programado por:** Kevin Esquivel

---

## 📋 Descripción

Este laboratorio implementa un programa de **Libro de Calificaciones** encargado de recibir las calificaciones de un grupo de estudiantes, calcular su total y determinar el promedio de las calificaciones introducidas.

El ejercicio presenta dos implementaciones del mismo problema, utilizando diferentes estructuras de repetición:

- **Repetición controlada por contador:** el programa solicita exactamente 10 calificaciones.
- **Repetición controlada por centinela:** el usuario puede introducir todas las calificaciones que desee y utiliza el valor -1 para indicar que terminó de ingresar datos.

El objetivo es observar cómo un mismo procedimiento puede resolverse utilizando diferentes mecanismos para controlar la repetición.

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET 10
- **IDE:** Visual Studio 2026
- **Tipo de aplicación:** Consola
- **Paradigmas:** Programación Orientada a Objetos y estructuras repetitivas

---

## 📁 Estructura del proyecto

El repositorio contiene dos proyectos independientes que resuelven el mismo problema utilizando diferentes métodos de repetición:

```text
LibretaCalificaciones/
│
├── LibroCalificaciones/
│   ├── Class1.cs
│   ├── Program.cs
│   └── LibroCalificaciones.csproj
│
└── LibroCalificaciones 2/
    ├── Class1.cs
    ├── Program.cs
    └── LibroCalificaciones 2.csproj
