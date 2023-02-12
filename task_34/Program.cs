Console.Clear();
Console.Write("seminar_5 task_34\n\n");

void print_array(ref int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]\n");
}

int[] random_array(int length=10, int min=100, int max=1000){
    int[] array = new int[length];
    for (int i = 0; i < length; i++){
        array[i] = new Random().Next(min, max);
    }
    return array;
}

bool is_even(ref int num){
    if (num % 2 == 0){
        return true;
    }
    else {
        return false;
    }
}

int amount_evens(ref int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (is_even(ref array[i])){
            count += 1;
        }
    }
    return count;
}

int[] arr = random_array();
print_array(ref arr);
Console.Write($"{amount_evens(ref arr)} even numbers in array");