/*
Esta aplicación de consola C# está diseñada para:
-Utilice matrices para almacenar los nombres de los estudiantes y las puntuaciones de las tareas.
-Utilice una declaración `foreach` para recorrer los nombres de los estudiantes como un bucle de programa externo.
-Utilice una declaración "if" dentro del bucle externo para identificar el nombre del estudiante actual y acceder a las puntuaciones de las tareas de ese estudiante.
-Utilice una declaración `foreach` dentro del bucle externo para iterar a través de la matriz de puntuaciones de asignación y sumar los valores.
-Utilice un algoritmo dentro del bucle exterior para calcular la puntuación media del examen de cada estudiante.
-Utilice una construcción `if-elseif-else` dentro del bucle externo para evaluar la puntuación promedio del examen y asignar una calificación con letras automáticamente.
-Integrar puntajes de créditos adicionales al calcular el puntaje final y la calificación con letras del estudiante de la siguiente manera:
    -detecta asignaciones de créditos adicionales en función de la cantidad de elementos en la matriz de puntajes del estudiante.
-divide los valores de las asignaciones de créditos adicionales por 10 antes de agregar puntajes de créditos adicionales a la suma de los puntajes de los exámenes.
-utilice el siguiente formato de informe para informar las calificaciones de los estudiantes:
    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

//muestra la fila del encabezado para puntuaciones/calificaciones
Console.Clear();
Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

/*
El bucle foreach exterior se utiliza para:
-iterar a través de los nombres de los estudiantes
-asignar las calificaciones de un estudiante a la matriz StudentScores
-suma de puntuaciones de tareas (bucle foreach interno)
-calcular la calificación numérica y en letras
-escribir la información del informe de puntuación
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    /*
        el bucle foreach interno suma las puntuaciones de las tareas
        Las tareas de crédito adicionales valen el 10% de la puntuación del examen.
        */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

//requerido para ejecutar en VS Code (mantiene las ventanas de Salida abiertas para ver los resultados)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
