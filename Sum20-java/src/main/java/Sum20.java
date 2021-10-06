import java.util.Scanner;

public class Sum20 {
    public static String getInput(){
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter 3 digits that sum up 20: ");
        return sc.nextLine();
    }

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

    public static int total20(String num){
        int total = 0;
        for (int x=0; x< num.length(); x++){
            total += Integer.parseInt(String.valueOf(num.charAt(x)));
        }
        return total;
    }

    public static String check20OrNot(int total){
        String display;
        System.out.println(total);
        if (total == 20) {
            display = "The numbers sum up 20";
        } else{
            display = "The numbers don't sum up 20";
        }
        return display;
    }

    public static void display(){
        String num;

        do {
            num  = getInput();
        } while (!isInputValid(num));

        int total = total20(num);
        System.out.println(check20OrNot(total));
    }

    public static void main(String[] args){
        display();
    }
}
