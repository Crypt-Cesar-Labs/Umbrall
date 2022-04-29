# Umbrall
_El proyecto Umbrall es una interfaz gráfica desarrollada en .Net para el monitoreo de los parámetros eléctricos recibidos desde los medidores de energía avanzados._

## Comenzando
_El proyecto Umbrall cuenta con múltiples herramientas como, monitoreo de datos en tiempo real, calculadora de costos, y consultas hacia la base de datos para obtener los valores de las tarifas proporcionada por CFE._

### Barra de herramientas
_En la barra de herramientas podemos encontrar diferentes opciones que corresponden a las diferentes funcionalidades de la aplicación._
![menu](https://user-images.githubusercontent.com/63091636/165979672-8aec7c52-07b0-4638-b943-ccd55486c4c1.png)

_Donde podemos encontrar las siguientes opciones:_
* Menu
* Reportes
* Acerca de
* Ayuda

## Pasos para iniciar el monitoreo
_Lo primero que se debe de hacer es realizar la configuraciones necesarias para establecer el dispositivo medidor con el cual se va a ralizar la comunicación y el tipo de cargos tarifarios que corresponde a la instalación eléctrica._

### Configuración de dispositivo

_Para entrar a la configuración del dispositivo seguimos la siguiente ruta._

![configuracio_dispositivo_path](https://user-images.githubusercontent.com/63091636/165980677-397d6a36-7fb9-4ee4-b5d9-ec3c87034410.png)

_Una vez dentro de la ventana de configuración del dispositivo queda escribir la dirección ip y el puerto que corresponde a el dispositivo medidor, dentro de una misma red local LAN; además de especificar si el medidor de parámetros eléctricos es SENECA o SIEMENS._ 

![configuracion_dispositivo](https://user-images.githubusercontent.com/63091636/165981837-20339c23-5e22-47ed-a0bf-2f20fbe6d729.png)

### Configuración para el tipo de cargos tarifarios a aplicar en mi instalación.
_Una vez se haya seleccionado el dispositivo correctamente especificando la dirección ip, el puerto y el dispositivo (SENECA o SIEMENS), toca seleccionar el tipo de instalación que se tiene para cada caso._

_Para entrar a la configuración de las tarifas, corresponde seguir la siguiente ruta:_

![configuracion_tarifas_path](https://user-images.githubusercontent.com/63091636/165982695-4de3bf69-e7e8-4a92-bebb-3d0029324201.png)

_Una vez dentro de la venta de configuración de tarifas contamos con cuatro multi-selectores que me pemitiran especificar los parámetros de busqueda adecuados para especificar el tipo de instalación, los cuales incluyen:_
* Año 
* Mes
* Tipo de tarifa
* División

![cunsulta_tarifa_empresa](https://user-images.githubusercontent.com/63091636/165983338-35b795c8-edcc-4092-aa67-0f9aecf8fb1a.png)

_Los resultados de la busqueda se muestrean en la sección derecha para cada cargo tarifario correspondiente a cada tipo de tarifa._

![consulta_tarifas_resultados](https://user-images.githubusercontent.com/63091636/165983625-c17ac7f2-c98f-4054-a109-d858a31c6b0f.png)

### Iniciando el monitoreo
_Para iniciar el monitoreo podemos presionar simplemente Ctrl+I o ir a la sección de menú y presionar Iniciar Monitoreo. En su defecto, para finalizar con el monitoreo podemos presionar Ctrl+D o clickear en Detener Monitoreo._

_La ventana de monitoreo luce como a continuación:_

![monitoreo](https://user-images.githubusercontent.com/63091636/165988135-d006459c-eb00-4273-9043-ced499bafa73.png)

## Calculadora de costos
_La aplicación cuenta también con un par de calculadora de costos que brindan la posibilidad de estimar costos dependiendo de el tipo de instalación que se especifique, ademas de proporcionar un medio comparativo frente a los recibos que ofrece CFE._
_Para encontrar la sección de las calculadoras basta con ir a la opción de de Reportes > Calculadora y seleccionar entre las dos opciones, las cuales son Calculadora Manual Ordinaria y Calculadora Manula Horaria. 

### Calculadora manual ordinaria
_La calculadora manual ordinaria cuenta, de nuevo, con la función de busqueda para los cargos tarifarios y opciones para ingresar los datos que corresponden a la cantidad de energía en kWh (inicio y final) y en kVAR (inicio y final), demanda y fecha (inicio y final)._ 

![calculadora_ordinaria](https://user-images.githubusercontent.com/63091636/165989677-119b491a-59da-4ee9-ae28-d8ee460c1a72.png)

_Para observar los resultados debemos presionar el botón de Calcular._

_Podemos ver un ejemplo de como lucen los resultados encerrados en un recuadro rojo._

![calculadora_ordinaria_resultados](https://user-images.githubusercontent.com/63091636/165990576-70eb1ca5-7f6d-419c-b53f-7cd345760bec.png)

## Calculadora manual horaria

La calculadora manual horaria difiere un poco de la anterior calculadora pero mantiene la misma función de busqueda para los cargos tarifarios. Los datos a ingresar para este caso corresponden a la energía en kWh (base, intermedia y punta), demanda kW (base, intermedia y punta), energía reactiva y fecha (inicio y final)._

![calculadora_horaria](https://user-images.githubusercontent.com/63091636/165991271-25dc6b5c-03d5-4d75-9e01-6d25b63c618c.png)

_Los resultados de ejemplo que se pueden ver con esta calculadora son encerrados en un recuadro rojo, como se puede ver a continuación:_ 

![calculadora_horaria_resultados](https://user-images.githubusercontent.com/63091636/165991509-67528b73-9ec7-4fc7-92dc-436370885ff8.png)

## Autores
Personas que ayudarona levantar el proyecto
*  César Martínez - Desarrollador
*  Jesus Rivera - Ingeniero eléctrico
*  José Zamora - Asesor e ingeniero

