# Respuestas a las preguntas teoricas:

1) C# no permite la herencia multiple. Sin embargo, en las clases podemos implementar múltiples interfaces.

2) Utilizaria una clase abstracta cuando ademas de definir metodos debemos implementarlos o declarar atributos que las clases hijas puedan heredar. En las interfaces solo podemos definir los metodos y no podemos declarar atributos, por lo que no nos serviria en el caso nombrado anteriormente. Por ejemplo, podría declarar una clase abstracta Vehiculo que tenga un atributo "color" y un metodo "Acelerar" que aumente la velocidad un 5% por segundo. Luego de esta clase podrían heredar ese atributo y ese metodo las clases Auto y Moto, y en ellas agregar otros atributos y metodos que creamos necesarios.

3) La Generalizacion entre clases es lo que comunmente se denomina Herencia. Continuando con la respuesta anterior, la Generalizacion permite la reutilización de código haciendo que las clases "hijas" hereden ciertos atributos y metodos de la clase "padre", pudiendo reutilizar ese codigo pero también permitiendo la sobrescritura de métodos si lo creemos necesario,

4) Las Interfaces son una especie de contrato en donde las clases que la implementan se comprometen a implementar los metodos declarados en la Intefaz. En las interfaces solo podemos definir nombre de los metodos, su tipo de retorno y tipo de cantidad de parametros. Como se dijo anteriormente, una clase puede implementar varias interfaces.

5) La diferencia entre Agregación y Composición es que, si bien ambas representan una relación de Todo/Parte, en la Agregación los objetos existen independientemente de la relación, es decir que si el objeto Todo es eliminado, el objeto Parte puede seguir existiendo. En cambio, en la Composición las partes viven y mueren en el objeto Todo, por lo que si este es eliminado el objeto Parte también desaparece.

6)
a) Verdadero
b) Falso
c) Falso