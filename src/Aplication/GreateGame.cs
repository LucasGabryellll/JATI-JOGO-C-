using Person;

namespace Application {
  public class GreateGame{
    List<Enimy> enimys = new List<Enimy>();

    Random attackEnimy = new Random();

    public GreateGame(int totalEnimys) {
      enimys = new List<Enimy>();

      for(int index=0; index < totalEnimys; index++){
        enimys.Add(new Enimy(attackEnimy.Next(101)));
      }
    }

    public List<Enimy> getEnimys(){return enimys;}
  }
}