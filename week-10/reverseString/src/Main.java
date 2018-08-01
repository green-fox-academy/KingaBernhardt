public class Main {

    public static void main(String[] args) {

        String whatToReverse = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
        System.out.println(doReversing(whatToReverse));
    }
    public static String doReversing(String whatToReverse){
        String theReversed = "";
        for (int i = whatToReverse.length()-1; i >= 0; i--){
            theReversed += whatToReverse.charAt(i);
        }
        return theReversed;
    }
}
