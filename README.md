# Proyecto Marzo 2024
## Sesión 14/03/2024

***Empezando Con Construct.***

Construct es un motor de juegos en 2D optimizado para web. 

Si bien no lo veo como un motor para una producción mas allá de algo pequeño, o mecánicas complejas, o, en general un juego final, realmente veo potencial a la hora de usarlo para conceptualizar prototipos de sistemas no demasiados complejos de una manera muy rápida y así hacerte una idea de en que dirección quieres que tome rumbo el desarrollo. 

Por ahora he hecho una pequeña prueba de un juego donde tienes que disparar a los enemigos a los enemigos que van apareciendo en una posición aleatoria, y la verdad es que ha sido muy rápido, si hubiera hecho esto en, digamos, Libgdx probablemente hubiera tardado el triple o el cuádruple.

## Sesión 15/03/2024

Acabe esto añadiendo unas animaciones básicas al jugador y los enemigos además de agregarle un efecto de shake a la cámara al disparar. Aunque no es para nada un juego, como prueba para las distintas mecánicas y facilidades que aporta Construct cumple su objetivo.

Además también use itchi.io para subirlo y probar como funciona eso, al ser un juego de navegador se puede probar desde la misma pagina. Aunque va bastante lento en cuanto a fotogramas, entiendo que se necesita al fin y al cabo optimizar y yo como solo estaba probando un poco las capacidades del motor no hice nada de eso. 
[Link al juego](https://pinguinotimothy.itch.io/juego-construct-prueba)


## Sesión 20/03/2024

***Empezando Con Phaser.***

Phaser es un framework para hacer videojuegos en HTML5.

La verdad es que, teniendo unas bases logicas de POO phaser y typescript no suponen demasiado reto, al menos no la parte basica que es lo que vi hasta ahora. Es todo bastante directo. El framework esta bastante bien documentado para las dudas que tuve y probablemente tendré.
Ademas el usar mapas de teselas la creacion de niveles de plataformeo es muy simple ya que con unas cuantas lineas todo lo que se dibuja se le añade fisicas automaticamente. Para cosas mas complejas como plataformas en las que puedes entrar por debajo o asi será mas dificil pero de momento es todo bastante sencillo.

Lo unico malo es que varios de los links del curso estaban caidos y estuve bastante perdido en algunas cosas porque funcionaban distinto y tuve que investigar alguna conversion, pero nada muy frustrante.

## Sesión 21/03/2024

Simplemente hice el examen de C# basico, que, la verdad es que de basico tenia poco.


## Sesión 27/03/2024

***Acabado Phaser.***

Terminado el juego con Phaser que he de decir que me ha roto bastante la cabeza y he tardado mas de lo que esperaba con esto. Es todo muy repetitivo, simple, pero repetitivo, no creo que me interese en general trabajar con typescript en el futuro la verdad, no me ha acabado de convencer.

Todos los assets estan directamente descargados del proyecto del curso de openwebinars, el juego es totalmente funcional tanto en dispotivos tactiles como con teclado y raton. Para ejecutarlo hay que usar el comando npm run dev en bash en la carpeta version00


## Sesión 07/04/2024

***Empezando Unity.***

Aqui empieza lo interesante de la carrera, al menos lo que mas me interesaba a mi, es cierto que los otros pueden llegar a estar bien pero para hacer un proyecto de verdad yo creo que unity es la opcion preferida.

De momento de lo que llevo del curso no hay mucho para probar porque lo que he visto hasta ahora es mas que nada las distintas funciones de unity como herramienta, no hubo codigo, un par de lineas para enseñar como funciona la consola y para enseñar un par de cosas mas pero ya. Primero que nada tienes que hacerte a la herramienta y sus funciones antes de pasar a machacar codigo al final. Tiene un monton de cosas que facilitan en general el proceso de desarollo, tags, prefabs, componentes, etc. Segun vaya avanzando, probablemente, habra mas cosas que aun desconozco que haran que todo sea mas simple.

## Sesión 13/04/2024

***Siguiendo Unity.***

Acabado el primer curso de unity y nada muy tangible de momento, probe a construir un proyecto ejecutable en la carpeta buildPrueba para hacer la prueba a ver como iba, despues de sentar las bases ahora tocará ya empezar a hacer cosas mas jugables.

## Sesión 21/04/2024

***Siguiendo Unity.***

Empezando con el curso de los componentes y las APIs, por ahora he aprendido a la gestion de los componentes, sus ciclos de vida y como crearlos en tiempo de ejecucion, es un tema bastante denso, tienen mucha cosa que gestionar y muchos metodos para relacionarse entre ellos, con sus hijos, padres, etc. Los ciclos de vida tambien tienen su cosilla, hay varios update y eso aun me confunde un poco.
Ahora me tocará aprender todo el tema de la API que sera ya algo mas tangible y que se pueda probar mas alla de lo que hice el ultimo dia.

## Sesión 27/04/2024

***Siguiendo Unity.***

Empezando con la API, aprendi varias cosas:
Clase Debug: No deja de ser lo tipico que hay en todos los sitios que sirve para imprimir mensajes de informacion, advertencia (Debug.LogWarning) y error (Debug.LogError).  

Clase Input: Que sirve para manejar los distintos metodos de entrada, teclado, raton, joystick, pantallas tactiles, etc.

Clase Screen: Sirve para recibir y cambiar distintas cosas relacionadas con como se ve el juego, resolucion, pantalla completa, la ventana de juego.

Clase Camera: Se usa para, igual que Screen, recibir y cambiar las propiedades de la camara, por defecto hay una principal que es la "Main Camera" pero tambien puede haber varias, por ejemplo en juegos donde hay pantalla dividida y asi.

Clase Time: Time sirve para saber como pasa el tiempo el juego, cuanto se tarda en hacer un frame, cuanto tiempo lleva x escena usandose, asi independientemente de los FPS (Frames-per-second) podemos hacer que el movimiento sea siempre el mismo, porque si no un juego que va a mas FPS iria mas rapido que otro a menos.

Clase Transform: Se encarga de gestionar las posiciones, rotaciones y la escala de los distintos GameObjects, se divide en 3 principales, Translate, Rotate, LookAt:

    -Translate: Sirve para el desplazamiento de los objetos.

    -Rotate:Sirve para la rotacion de los objetos en funcion de un eje.

    -LookAt: Sirve para modificar el eje que hace que el objeto mire a un sitio.

Instanciar Objetos: Instanciar es para duplicar en tiempo de ejecucion objetos como escenas o prefabs que ya han sido creados antes, esto hay que hacerlo con cuidado porque consume muchos recursos y deja mucho trabajo al GarbageCollector.

Destruir Objetos: Es para lo contrario que instanciar, por ejemplo cuando has matado a un enemigo, lo suyo es destruirlo para que no se quede en memoria y lleve a problemas de rendimiento.

Clase Random: No deja de ser una clase que sirve para devolver valores aletorios.
