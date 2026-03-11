#  Proyecto Videojuego 2D en Unity

##  Descripción del Proyecto

Este proyecto consiste en el desarrollo de un videojuego básico en 2D utilizando el motor gráfico Unity. El objetivo del proyecto es comprender los fundamentos del desarrollo de videojuegos, incluyendo la creación de escenas, configuración de cámara, implementación de físicas y programación de mecánicas básicas para el control de un personaje.

El proyecto fue desarrollado como parte de una actividad académica enfocada en el aprendizaje del entorno de desarrollo Unity y el uso del lenguaje de programación C# para videojuegos.

---

##  Tecnologías Utilizadas

* Unity (Motor gráfico para desarrollo de videojuegos)
* C# (Lenguaje de programación utilizado en Unity)
* Git (Control de versiones)
* GitHub (Repositorio del proyecto)

---

##  Estructura del Proyecto

```
Assets/
 ├── Scenes
 │     └── MainScene.unity
 │
 ├── Scripts
 │     ├── PlayerMovement.cs
 │     ├── CameraFollow.cs
 │     └── CameraBounds.cs
 │
 ├── Sprites
 │
 └── Animations
```

Esta estructura permite organizar adecuadamente los recursos del proyecto y facilita su mantenimiento.

---

##  Funcionalidades Implementadas

El proyecto incluye las siguientes características:

* Creación de una escena principal
* Personaje 2D con físicas
* Movimiento horizontal del personaje
* Sistema de salto
* Configuración de cámara en modo 2D
* Cámara que sigue al jugador
* Límites de cámara dentro del escenario
* Organización del proyecto en carpetas

---

##  Configuración de la Cámara

La cámara fue configurada utilizando proyección **Orthographic**, que es la más utilizada en videojuegos 2D.
Se implementó un script de seguimiento que permite que la cámara siga al personaje durante su desplazamiento en el escenario.

---

##  Cómo Ejecutar el Proyecto

1. Descargar o clonar el repositorio:

```
git clone https://github.com/tuusuario/Juego2D_Unity.git
```

2. Abrir el proyecto desde **Unity Hub**.

3. Cargar la escena principal ubicada en:

```
Assets/Scenes/MainScene
```

4. Presionar el botón **Play** para ejecutar el videojuego.

---

##  Objetivos de Aprendizaje

Este proyecto permite comprender:

* Uso básico del motor gráfico Unity
* Creación de escenas 2D
* Uso de Rigidbody2D y colliders
* Programación en C# dentro de Unity
* Configuración de cámara en videojuegos 2D
* Uso de repositorios para control de versiones

---

##  Referencias

Unity Technologies. (2021). *Unity User Manual*. https://docs.unity3d.com

Unity Technologies. (2021). *Unity Scripting API*. https://docs.unity3d.com/ScriptReference/

GitHub, Inc. (2023). *GitHub Documentation*. https://docs.github.com

---


