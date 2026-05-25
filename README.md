# TRABAJO-PR-CTICO-ESPECIAL-Intro-a-C-
PRIMERA PARTE

-Compilar en Linux (ej. Ubuntu) y Mono (ambiente .NET para Unix/Linux):

Referencias:

https://es.wikipedia.org/wiki/Proyecto_Mono

https://www.mono-project.com/

Resumen mínimo de indicaciones (específicas Ubuntu):

a) Instalación de Mono

$ sudo apt update

$ sudo apt install mono-complete

b) Compilación proyecto

Descomprimir el archivo .zip adjunto

$ xbuild ExMetodosVirtuales.csproj

......

Build succeeded.

	 0 Warning(s)

	 0 Error(s)



Time Elapsed 00:00:01.0004060

c) Ejecución

$ bin/Debug/ExMetodosVirtuales.exe

SEGUNDA PARTE

Se pide realizar las siguientes modificaciones y recompilación en cada caso (se recomienda git para cada item de esta parte)

Ref: https://learn.microsoft.com/es-es/dotnet/api/system.drawing.pen.color?view=windowsdesktop-9.0#system-drawing-pen-color

a) Las figuras deben mostrarse en trazo rojo

b) Idem anterior, cada una en un color distinto (mantener en lo posible la generalización del código)

c) implementar:

c.1) Los tres colores deben elegirse aleatoriamente. Sugerencias: ver clases Random() y métodos de la clase Color() por ejemplo: Color.FromArgb() 

c.2) [OPCIONAL] Proponer, y si es posible implementar algún mecanismo para que todas las figuras siempre contrasten mínimamente de forma que se puedan distinguir del fondo blanco.

d) Las tres figuras deberán mostrarse en tamaños proporcionalmente crecientes, vistas de izquierda a derecha.

e) Agregar al modelo de clases estas dos nuevas figuras (y lograr que se dibujen):

e.1) Triángulo isósceles

e.2) Triángulo equilátero

NOTA: En caso de no poder cumplir la fecha de entrega propuesta, comunicarlo y se considerará una posible extensión del plazo si el pedido resulta razonable.
