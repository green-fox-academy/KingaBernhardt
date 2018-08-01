public class Main {

    public static void main(String[] args) {
        Car audi = new Car();
        Car bmw = new Car(10, 40);
        Station mol = new Station();
        System.out.println(audi.toString());
        System.out.println(bmw.toString());
        System.out.println(mol.toString());

        mol.refill(audi);
        mol.refill(bmw);
        System.out.println(audi.toString());
        System.out.println(bmw.toString());
        System.out.println(mol.toString());
    }
}
