public class Random {
    public String generator(){

        String[] firstPart = {"he", "goodness", "always", "never"};
        String[] secondPart = {"my", "admin", "hawaii"};
        String[] thirdPart = {"give", "sleep"};

        int firstLength = firstPart.length;
        int secondOnesLength = secondPart.length;
        int thirdOnesLength = thirdPart.length;

        int random = (int) Math.random()*firstLength;
        int randomTwo = (int) Math.random()*secondOnesLength;
        int randomThird = (int) Math.random() * thirdOnesLength;

        String sentence = firstPart[random] + " " + secondPart[randomTwo] + " " + thirdPart[randomThird];
        return sentence;
    }
}
