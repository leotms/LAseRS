# LAseRS

**_LAseRS_** es un pequeño juego interactivo de Realidad Aumentada programado en Unity 5.5.0 que hace uso de la herramienta Vuforia. Este juego fue presentado como el primer proyecto de 
la asignatura _Tópicos Especiales en Realidad Aumentada_ de la Universidad Simón Bolívar durante el 
trimestre Enero - Marzo 2017.

## Características y Funcionalidades

La funcionalidad principal consiste en el reconocimiento de marcas que contienen distintos láseres con los colores primarios
(amarillo, azul y rojo) e ir combinando los láseres para lograr el color adecuado y hacer lograr despegar la nave espacial.

<ul style="display:inline-block;">
<img alt="Nave" src="https://github.com/leotms/LAseRS/blob/master/Images/Cohete_RA.jpg?raw=true" width="250px" >
<img alt="Laser Rojo" src="https://github.com/leotms/LAseRS/blob/master/Images/Pistola_LaserAmarillo_RA.jpg?raw=true" width="250px" >
<img alt="Laser Azul" src="https://github.com/leotms/LAseRS/blob/master/Images/Pistola_LaserAzul_RA.jpg?raw=true" width="250px" >
<img alt="Laser Amarillo" src="https://github.com/leotms/LAseRS/blob/master/Images/Pistola_LaserRojo_RA.jpg?raw=true" width="250px" >
</ul>

Inicialmente, el usuario puede usar cualquiera de los tres laseres de colores y combinarlos con el espejo para hacer los colores secundarios:
Naranja, Verde y Morado. Ademas con estos colores secundarios, se pueden activar 3 robots distintos que generan a sus vez sus propios colores:
Rosado, Cyan y Turqueza.

<ul style="display:inline-block;">
<img alt="Espejo" src="https://github.com/leotms/LAseRS/blob/master/Images/Espejo_RA.jpg?raw=true" width="250px" >
<img alt="Robot Cyan" src="https://github.com/leotms/LAseRS/blob/master/Images/Robot_LaserCian_RA.jpg?raw=true" width="250px" >
<img alt="Robot Rosa" src="https://github.com/leotms/LAseRS/blob/master/Images/Robot_LaserRosado_RA.jpg?raw=true" width="250px" >
<img alt="Robot Turqueza" src="https://github.com/leotms/LAseRS/blob/master/Images/Robot_LaserTurquesa_RA.jpg?raw=true" width="250px" >
<img alt="Combinacion Naranja" src="https://github.com/leotms/LAseRS/blob/master/Images/Combinacion_Lasers.jpg?raw=true" width="250px" >
<img alt="Combinacion Robot Cyan" src="https://github.com/leotms/LAseRS/blob/master/Images/Combinacion_Lasers_Robot_Cian.jpg?raw=true" width="250px" >
<img alt="Combinacion Rosado" src="https://github.com/leotms/LAseRS/blob/master/Images/Combinacion_Lasers_Robot_Rosado.jpg?raw=true" width="250px" >
<img alt="Combinacion Turq" src="https://github.com/leotms/LAseRS/blob/master/Images/Combinacion_Lasers_Robot_Turquesa.jpg?raw=true" width="250px" >
<img alt="Cohete" src="https://github.com/leotms/LAseRS/blob/master/Images/Despegue_Cohete.jpg?raw=true" width="250px" >
</ul>

Este juego, trabaja con un sistema de interacción directa, puesto que el usuario representa un
agente y el juego una colección pasiva de objetos que esperan a ser manipulados por dicho usuario. Así mismo, 
está es tanto educativo como recreacional, ya que enseña como se forman los colores secundarios a partir de los primarios, además que estimula la memoria de como se
obtienen los colores de los robot todo haciéndolo de manera didáctica y divertida dado que se trata de cumplir un objetivo lo que incentiva a hacerlo de buena manera.

## Marcas

Aquí se pueden ver las marcas principales de los laseres primarios y del espejo:

![alt text](https://github.com/leotms/LAseRS/blob/master/Markers/Cannon_1.jpg?raw=true "Agua")
![alt text](https://github.com/leotms/LAseRS/blob/master/Markers/Cannon_2.jpg?raw=true "Tierra")
![alt text](https://github.com/leotms/LAseRS/blob/master/Markers/Cannon_3.jpg?raw=true "Fuego")
![alt text](https://github.com/leotms/LAseRS/blob/master/Markers/Mirror.jpg?raw=true "Aire")

Y estas son las marcas de los robots y del la nave espacial:

![alt text](https://github.com/leotms/LAseRS/blob/master/Markers/Robot_1.jpg?raw=true "Agua")
![alt text](https://github.com/leotms/LAseRS/blob/master/Markers/Robot_2.jpg?raw=true "Tierra")
![alt text](https://github.com/leotms/LAseRS/blob/master/Markers/Robot_3.jpg?raw=true "Fuego")
![alt text](https://github.com/leotms/LAseRS/blob/master/Markers/Rocket.jpg?raw=true "Aire")

El set de imágenes para el reconocimiento está incluido en este repositorio en el directorio de `Markers`. 

## Instalación y Prueba

Este repositorio contiene el código fuente necesario. Se recomienda el uso de Unity 5.5.0, no se ha probado la compatibilidad
del código en versiones anteriores.

Basta clonar o descargar el código fuente e importar el proyecto desde Unity.

El equipo debe disponer de cámara frontal y las marcas deben estar correctamente impresas sobre papel blanco. Para las pruebas
es necesario tomar en cuenta factores como la luz o el brillo que puedan evitar el correcto reconocimiento de las marcas.

El paquete de Vuforia ya se encuentra incluido en este repositorio y no hace falta descargarlo o importarlo nuevamente.

El juego esta diseñado para ser utilizado en dispositivos Android. Así que se incluyen en este repositorio compilaciones para 
las versiones 4.4, 5.0 y 6.0 de Android en el directorio `AndroidBuilds` que estan listas para ser descargadas y probadas.

## Autores
- [Cinthya Ramos.](https://github.com/CinthyaRamos)
- [Patricia Valencia.](https://github.com/patriv)
- [Leonardo Martínez.](https://github.com/leotms)


## Enlaces Externos
- [Unity](https://unity3d.com/es)
- [Vuforia](https://www.vuforia.com)

## Última Modificación: 
31 de Marzo, 2017.
