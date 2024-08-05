using PluralSightLearning.RH;

namespace PluralSightLearning.Tests
{
    public class FuncionarioTestes
    {
        [Fact]
        public void Trabalhar_Adiciona_Horas_Corretamente()
        {
            //Arange
            Funcionario funcionarioTest = new Funcionario("Gabriel", "De Oliveira", "gabriel.oliv.silva@hotmail.com", new DateTime(2001, 09, 19), 30);
            int HorasTrabalhadas = 3;
            //Act
            funcionarioTest.Trabalhar(HorasTrabalhadas);
            //Assert
            Assert.Equal(HorasTrabalhadas, funcionarioTest.HorasTrabalhadas);
        }
        [Fact]
        public void Trabalhar_Adicional_Se_Vazio()
        {
            Funcionario funcionarioTest = new Funcionario("Gabriel", "De Oliveira", "gabriel.oliv.silva@hotmail.com", new DateTime(2001, 09, 19), 30);

            funcionarioTest.Trabalhar();

            Assert.Equal(1, funcionarioTest.HorasTrabalhadas);
        }
    }
}