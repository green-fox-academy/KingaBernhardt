public class Station {
    private int gasAmount;

    public Station(){
        gasAmount = 100;
    }

    public Station(int gasAmount) {
        this.gasAmount = gasAmount;
    }

    public void refill(Car car){
            int neededGas = car.getCapacity() - car.getGasAmount();
            if (neededGas > 0) {
                if (gasAmount >= neededGas){
                    car.setGasAmount(car.getCapacity());
                    gasAmount -= neededGas;
                } else {
                    car.setGasAmount(car.getGasAmount() + gasAmount);
                    gasAmount = 0;
                }
            }
    }

    @Override
    public String toString() {
        return "Station{" +
                "gasAmount=" + gasAmount +
                '}';
    }
}
