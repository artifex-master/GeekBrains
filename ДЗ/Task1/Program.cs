using System.Collections.Generic;
// Глобальные переменные
int i = 1;
int j = 0;
int sum = 0;
int intVal;
List<int> arr = new List<int> { };


// Присваиваем значение в переменную convertedVal
string convertedVal = Console.ReadLine();
string q = "q";
// convertedVal - число?
int num;
bool isInt = int.TryParse(convertedVal, out num);

while(sum % 2 == 0) {
    // Введите число
    Console.Write("Введите число: ");

    if (isInt)
    {
        i = i * 10;
        if (num > i)
        {
            i *= 10;
        }
        else
        {
            i = i / 10;
        }

        while (num > 1)
        {
            intVal = num / i;
            arr.Add(intVal);
            num = num - (intVal * i);
        }
        arr.Add(num);

        while(j < arr.Count) {
            sum = sum + arr[j];
            j += 1;
        }

    }
    else {
        if(convertedVal == q) {
            break;
        }
    }

}



