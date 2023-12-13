# DOCUMENTACIÓN EJERCICIO 23

## CREACIÓN DEL REPOSITORIO
- Primero he creado el repositorio en Github, y luego lo he clonado en mi ordenador:

![Alt text](images/image.png)

- Clonación:

![Alt text](images/image-1.png)

---

## PRUEBA DE PERMISOS PARA HACER PUSH
- Para la prueba del push, he creado un documento .txt vacío y he probado de hacer git add, git commit y git push para actualizar el repositorio local al repositorio remoto:

![Alt text](images/image-2.png)

- Y ahora, hago todos los comandos de git para verificar que tengo permisos:

![Alt text](images/image-3.png)

- Como estamos en un ordenador compartido, no es lo ideal crear un usuario global en github, por eso como no existe me pide crear un nuevo usuario para poder hacer el commit y lo creo de manera local sólo para este repositorio.

---

## CREACIÓN DEL PROYECTO Y DE LAS TAREAS
- Primero, hemos de crear un proyecto nuevo para este repositorio. Nos vamos al apartado de projects, y le damos a 'New project'.

![Alt text](images/image-4.png)

- Después, nos pide que tipo de proyecto queremos crear, la vista que va a tener de manera visual. Elegimos el board, y después le damos un nombre:

![Alt text](images/image-5.png)

- Una vez creado, podemos añadir varias tareas en el proyecto:

![Alt text](images/image-6.png)

- Y cuando empecemos a trabajar en una tarea en concreto, la movemos a 'In Progress':

![Alt text](images/image-7.png)

---

## CREACIÓN DEL SCRIPT Y CÓDIGO INICIAL

### Primera tarea: Creación variables y mensajes generales
- Asi quedaría el código del programa principal sólo con el código del método Main:

![Alt text](images/image-8.png)

- Una vez terminada la primera tarea, hacemos el commit y push para crear una pull request. Después, en el github podemos aceptar la pull request una vez compruebe que todo está correcto y después se nos habrá actualizado el projects automáticamente si hemos indicado 'closes #X' en el mensaje del commit donde 'x' es el número de la tarea acabada.

- Y creamos una nueva branch para la siguiente tarea:

![Alt text](images/image-11.png)

### Segunda tarea: Métodos para calcular cada área con sobrecarga
- Este es el código de los métodos con sobrecarga para cada figura:

![Alt text](images/image-9.png)

- Este es el mensaje del commit para cerrar la segunda tarea del project:

![Alt text](images/image-10.png)

- Y después verificamos el pull request que se crea al hacer el push después del commit:

![Alt text](images/image-12.png)

- También se nos habrá actualizado la tarea del projects automáticamente:

![Alt text](images/image-13.png)

- Y asi sucesivamente con todos las tareas relativas al código principal del programa.

## UNIT TESTING

### Script del unit testing con métodos del script principal

#### Test del cuadrado y del rectángulo:
![Alt text](images/image-14.png)

#### Test del círculo y del pentágono:
![Alt text](images/image-15.png)

- Y con esto ya tendríamos el ejercicio acabado y los unit test funcionando de manera correcta:

![Alt text](images/image-16.PNG)