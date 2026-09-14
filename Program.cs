string nombreEstudiante = "Roger";

double examen1 = 85.5;
double examen2 = 92.0;
double examen3 = 78.5;

double porcentajeAsistencia = 90;


double promedioExamenes = (examen1 + examen2 + examen3) / 3;


double calificacionFinal = (promedioExamenes * 0.8) + (porcentajeAsistencia * 0.2);


Console.WriteLine("Estudiante\t\tPromedio\tAsistencia\tCalificación final");

Console.WriteLine($"{nombreEstudiante}\t\t\t{promedioExamenes:F2}\t\t{porcentajeAsistencia}%\t\t{calificacionFinal:F2}");

//Console.WriteLine($"Calificación Final: {calificacionFinal:F3}");
