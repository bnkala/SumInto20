import java.util.Scanner;

public class Sum20 {
    /**
     The user is asked to enter exactly 3 digits as input
     @returns: 3-digit input*/
    public static String getInput(){
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter 3 digits that sum up 20: ");
        return sc.nextLine();
    }


    /**
     The input is validated to see the actual length is 3 and is numerical
     @returns: true if the input is valid else false if one condition is false*/
    public static boolean isInputValid(String num){
        if (num.length() != 3){
            System.out.println("Invalid Input! Input should only have 3 digits");
            return false;
        }

        if (!(num.matches("[0-9]+"))){
            System.out.println("Invalid Input! Input should only have digits");
            return false;
        }
        return true;
    }


    /**
     The input is iterated to determine the total sum of 3 digits
     @returns: total of 3 digits*/
    public static int total20(String num){
        int total = 0;
        for (int x=0; x< num.length(); x++){
            total += Integer.parseInt(String.valueOf(num.charAt(x)));
        }
        return total;
    }


    /**
    The result is validated to see whether it is actually 20 or not
    @returns: a statement whether the input sum up 20 or not
    */
    public static String check20OrNot(String num, int total){
        String display;
        System.out.println(total);
        if (total == 20) {
            display = num+ " sum up 20";
        } else{
            display = num+" don't sum up 20";
        }
        return display;
    }


    /**
    The function calls the functions and prints the actual output
    */
    public static void display(){
        String num;

        do {
            num  = getInput();
        } while (!isInputValid(num));

        int total = total20(num);
        System.out.println(check20OrNot(num, total));
    }

    public static void main(String[] args){
        display();
    }
}
