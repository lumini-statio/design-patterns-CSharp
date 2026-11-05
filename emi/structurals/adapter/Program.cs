// El sistema de monitoreo de un laboratorio muestra en un listado la temperatura de todos
// sus sensores. Todos los sensores propios se usan a través de la misma interfaz, que
// devuelve grados Celsius; un sensor propio marca hoy 25 °C.

// Se compró un termómetro importado. Su librería expone un método con otro nombre que
// devuelve grados Fahrenheit (hoy, 98.6) y no se puede modificar. El listado tiene que incluir
// el termómetro nuevo sin casos especiales ni cambios en su código. Conversión: (F − 32) ×
// 5 / 9.

using adapter;

Sensor localSensor = new LocalSensor(25);
ImportedSensor importedSensor = new ImportedSensor(98.6);
Sensor sensorAdaptado = new LocalSensorAdapter(importedSensor, 0);

List<Sensor> sensors = new()
{
    localSensor,
    sensorAdaptado
};

MonitoringSystem monitoringSystem = new(sensors);
monitoringSystem.ListTemps();

