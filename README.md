Enlace video en youtube: https://youtu.be/ZAKkpZlPlA0

Manual Técnico – Sistema Inscripciones Kinder

1.	Introducción:
Este manual proporciona información detallada sobre la implementación, configuración del Sistema de Inscripciones del Kínder.
2.	Descripción del proyecto:

El Sistema Web de Inscripciones para el Kinder (Freireland) es una solución integral diseñada para simplificar y agilizar la gestión administrativa de este jardín de niños. Este sistema permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) de manera eficiente sobre diversos elementos, como estudiantes, padres, profesores, usuarios, cursos y materias.
Con una interfaz intuitiva, accesible y amigable, el sistema facilita la inscripción, actualización y eliminación de registros de estudiantes. Además, se gestiona la información de los padres de manera centralizada, asegurando una comunicación fluida entre la institución y los responsables de los niños.
El sistema no solo ayuda con las inscripciones, sino que también se encarga de cosas como manejar la información de los profesores y usuarios. Proporciona herramientas que ayudan a controlar quién tiene acceso al sistema y cómo se administran los diferentes roles. Además, los cursos y materias están organizados de manera ordenada. Una característica destacada del sistema es la capacidad para gestionar el proceso de pagos de mensualidades y planes de pagos de manera automatizada. Esto simplifica la administración financiera, proporcionando un seguimiento detallado de los pagos realizados y pendientes.
En resumen, el Sistema Web de Inscripciones para Kinder se erige como una herramienta esencial para la gestión integral de la institución, optimizando procesos, mejorando la comunicación y asegurando un control eficaz sobre la información clave relacionada con estudiantes, profesores, padres y aspectos financieros.

3.	Roles / integrantes
-	Agreda Valeria (Developer)
-	Figueroa Miguel (DB Master/ Developer/ Git Master)
-	Rojas Valeria (Team Leader/ Developer)
-	Sejas Boris (Developer)
4.	Arquitectura del software: 
El sistema está compuesto por tres elementos principales: el Backend desarrollado en ASP.NET con el lenguaje C#, la Base de Datos gestionada a través de SQL Server Management, y el Frontend realizado en ASP.NET para aplicaciones web. A continuación, se detalla cada componente:
	
4.1 Backend - ASP.NET C#: El núcleo del sistema es el backend, implementado con ASP.NET y C#. Esta parte se encarga de la lógica de negocio, el procesamiento de datos y la gestión de la comunicación con la base de datos.
4.2 Base de Datos - SQL Server Management: La gestión de datos se lleva a cabo mediante SQL Server Management, un sistema que proporciona un entorno sólido para almacenar y acceder a la información del sistema. Esto simplifica la administración de la base de datos relacional.
4.3 Patrón de Diseño - DAO (Data Access Object): Para mejorar la modularidad y mantenibilidad del sistema, se ha implementado el patrón de diseño DAO. Este patrón separa la lógica de acceso a datos del resto del código, proporcionando una capa de abstracción que facilita la gestión eficiente de la información.
4.4 Frontend - ASP.NET Web: La interfaz de usuario se ha desarrollado utilizando ASP.NET para aplicaciones web. 
Este frontend permite a los usuarios interactuar con el sistema a través de navegadores web, ofreciendo una presentación amigable y accesible de la información.
Esta arquitectura garantiza una estructura organizada y eficiente, mejorando la comprensión y mantenimiento del sistema a lo largo del tiempo.

5.	Requisitos del sistema:
●	Requerimientos de Hardware (mínimo): (cliente) 
●	Requerimientos de Software: (cliente)
o	Windows:
▪	Windows 7 (y versiones posteriores)
▪	Windows Server 2008 R2 (y versiones posteriores)
o	macOS:
▪	macOS 10.12 (Sierra) y versiones posteriores
o	Linux:
▪	Ubuntu 16.04 LTS (y versiones posteriores)
▪	Debian 9 (y versiones posteriores)
▪	Fedora 26 (y versiones posteriores)
▪	openSUSE 15.1 (y versiones posteriores)
o	Chrome OS:
▪	Chrome OS es el sistema operativo desarrollado por Google específicamente para dispositivos Chromebook. Los navegadores como Google Chrome y otros basados en Chromium están disponibles y se mantienen actualizados en los dispositivos Chrome OS.
o	iOS (Dispositivos móviles):
▪	iOS 13 y versiones posteriores para iPhone y iPad.
o	Android (Dispositivos móviles):
▪	Android 5.0 (Lollipop) y versiones posteriores.

●	Requerimientos de Hardware (server/ hosting/BD)
o	
 
●	Requerimientos de Software (server/ hosting/BD)
o	Windows Server 2022
6.	Instalación y configuración: Instrucciones detalladas sobre cómo instalar el software, configurar los componentes necesarios y establecer la conexión con otros sistemas o bases de datos

	Pasos para la configuracion del programa:
	1- Definir si la base de datos estara alojada en el mismo servidor o en la nube.
Modificar la cadena de conexion que en el archivo BaseImpl ([connectionString = @”” ])
	
Pasos Detallados Para el Servidor:
1. Preparación del Servidor:
Accede al servidor Windows Server con privilegios administrativos.
Verifica las actualizaciones de Windows.
2. Instalación de .NET Framework:
Descarga e instala la versión necesaria del .NET Framework.
Verifica la instalación mediante comandos de consola o interfaz gráfica.
3. Configuración de IIS:
Accede al Administrador de Internet Information Services (IIS).
Crea un nuevo sitio web o aplicación para el proyecto web.
Asigna el directorio raíz del proyecto al sitio o aplicación en IIS.
4. Configuración de la Aplicación Web:
Copia los archivos del proyecto en el directorio raíz en IIS.
Asegúrate de que los archivos de configuración (web.config) estén adecuadamente configurados.
5. Configuración de Conexiones:
Si se conecta a una base de datos, asegúrate de configurar la conexión en los archivos correspondientes.
Verifica la accesibilidad y credenciales del servidor de base de datos.
6. Seguridad y Permisos:
Ajusta los permisos de archivo y carpeta según las necesidades de la aplicación.
Implementa medidas de seguridad para proteger la aplicación y el servidor.
7. Pruebas:
Realiza pruebas exhaustivas para garantizar el funcionamiento correcto de la aplicación en el entorno del servidor Windows.


	

7.	PROCEDIMIENTO DE HOSTEADO / HOSTING (configuración)
Usando como referencia Somee: Es necesario registrarse en la pagina, esta ya nos brinda un espacio para alojar el sitio Web y una base de datos de forma gratuita.
●	Sitio Web.
o	En la seccion de WebSites nos permitira la creacion de un hosteo.
o	Rellenar el formulario, el nombre del sitio y seleccionar la version .net4.7 o superior.
o	Una vez creado debemos dirigirnos a la seccion que creamos, nos dirigimos a la pestaña ‘File Manager’
o	Seleccionamos la opcion de Subir o Upload y subimos un archivo ZIP. La pagina descromprimira el archivo.

Esperar maximo 3 min hasta que se pueda hacer la prueba de la pagina.
●	B.D.
o	En la seccion de MS SQL creamos una base de datos, en el formulario es necesario poner el mismo nombre al del backup, en este caso seria ‘dbInstitution’
o	Una vez creada, nos vamos al pestaña de Restore y subimos el backup con 0 datos.
o	Para verificar si se subio correctamente y tenemos relacionados el nombre con la base, podemos ir a la pestaña de Run Scripts y podemos ejecutar una consulta SQL ej: “SELECT * FROM [User]”
●	API / servicios Web
●	Otros (firebase, etc.)

Detalle DETALLADO paso a paso de la puesta en marcha en hosting, tanto para el sitio Web, API, B.D., etc.etc. (incluir scripts BD, Credenciales de acceso server, root BD, Admin, users clientes etc.)

8.	GIT : 
https://github.com/DonFigue/PR-KINDER/tree/5034a6d733a1b0b4c4282c3108038d82b013d845/Final 

9.	Personalización y configuración: En el actual desarrollo del software, es importante destacar que no se proporcionan funciones específicas de personalización o configuración para ajustar el sistema a necesidades individuales. Este software ha sido diseñado con un conjunto predeterminado de características y configuraciones, y no incluye opciones de ajuste o personalización a nivel de usuario.
10.	Seguridad: 
La seguridad de nuestro software es una prioridad fundamental. A continuación, se detallan las consideraciones de seguridad implementadas y las recomendaciones para garantizar la protección de los datos y la integridad del sistema:
10.1 Permisos de Acceso: El software implementa un sistema de roles que define niveles de acceso para los usuarios. Los roles incluyen "Administrador", "Secretario" y "Director". Cada rol tiene permisos específicos para acceder al sistema. En caso de probar el sistema por primera vez, ingresar con el nombre de usuario “figue11” y contraseña “Figue123@”.
10.2 Autenticación: La autenticación se realiza mediante un sistema de nombre de usuario y contraseña, con políticas de contraseñas que incluyen requisitos de longitud y complejidad. 
10.3 Prácticas de Seguridad Recomendadas:
Se recomienda a los usuarios cambiar sus contraseñas regularmente.
Evitar acceder al sistema desde dispositivos no seguros.
No compartir credenciales de acceso.
10.4 Protección de Datos: Los datos se almacenan en una base de datos para garantizar la privacidad y confidencialidad. Los datos sensibles están protegidos mediante técnicas de cifrado.
10.5 Respuesta a Incidentes: En caso de cualquier incidente de seguridad, los usuarios deben informar inmediatamente al equipo de soporte técnico. Para dar solución al problema.

11.	Depuración y solución de problemas: 

11.1 Identificación de Problemas:
Si se experimenta lentitud en el rendimiento, verificar la conexión a internet y asegurar de que el hardware cumple con los requisitos mínimos del sistema.
Si se encuentra inconsistencias en los datos, revisa las entradas y ajusta cualquier información incorrecta (validaciones).
11.2 Mensajes de Error:
Error de Autenticación: Asegúrate de ingresar las credenciales correctamente. Si olvidaste tu contraseña, sigue el botón de recuperación de contraseña.
11.3 Posibles Conflictos con Otros Sistemas o Componentes:
Si utilizas complementos o extensiones del navegador, desactívalos temporalmente para descartar posibles conflictos.
Al integrar con otros sistemas, verifica las versiones y configuraciones compatibles.
11.4 Soporte Técnico: Si encuentras problemas no resueltos, comunícate con nuestro equipo de soporte técnico a través de rcv0031261@est.univalle.edu - fpm5000352@est.univalle.edu - smb0031213@est.univalle.edu - acv5001715@est.univalle.edu . Proporciona detalles específicos sobre el problema para una asistencia más rápida.


12.	Glosario de términos: 
-	Backend: El componente central del sistema que maneja la lógica de negocio, procesamiento de datos y comunicación con la base de datos. En este caso, implementado en ASP.NET C#.
-	Frontend: La interfaz de usuario del sistema, desarrollada utilizando ASP.NET para aplicaciones web. Permite a los usuarios interactuar con el sistema a través de navegadores web.
-	Base de Datos: Sistema de almacenamiento y recuperación de datos gestionado a través de SQL Server Management. Proporciona un entorno sólido para almacenar y acceder a la información del sistema.
-	Autenticación: Proceso de verificar la identidad de un usuario mediante un sistema de nombre de usuario y contraseña. Incluye políticas de contraseñas seguras.
-	Depuración: Es el proceso de identificación y solución de problemas o errores en el software.
-	Soporte Técnico: Equipo disponible para ayudar a los usuarios con problemas o preguntas relacionadas con el software. Se proporcionan contactos específicos.



13.	Referencias y recursos adicionales: 
-	Documentación de SQL Server: Documentación oficial de SQL Server Management.
-	Descargar SSMS : Descarga de SQL Server Management Studio

14.	Herramientas de Implementación:
●	Lenguajes de programación: C# - Asp.net. 
La base del desarrollo backend, proporcionando una sólida estructura para la lógica de negocio y la comunicación con la base de datos.
●	Frameworks: ASP.NET.
 Utilizado para el desarrollo del frontend web, ofreciendo un marco robusto para la creación de interfaces de usuario interactivas y funcionales.

15.	Bibliografía
https://learn.microsoft.com/es-es/aspnet/overview 

