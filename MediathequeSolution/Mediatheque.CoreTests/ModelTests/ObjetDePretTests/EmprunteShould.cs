using Mediatheque.Core.Model;

namespace Mediatheque.CoreTests.ModelTests.ObjetDePretTests
{
    [TestClass()]
    public class EmprunteShould()
    {
        [TestMethod()]
        public void FillEmprunteur()
        {
            // Arrange
            var objetDePret = new ObjetDePret("Scie sauteuse");

            // Act
            objetDePret.Emprunte("Bernard");

            // Assert
            Assert.AreEqual("Bernard", objetDePret.Emprunteur, "La propriété Emprunteur aurait dû être mise à jour avec le nom de l'emprunteur.");
        }

        [TestMethod()]
        public void ReturnTrue_IfObjetIsAvailable()
        {
            //Arrange
            var objetDePret = new ObjetDePret("chaise");

            //Act
            var actual = objetDePret.Emprunte("albert");

            //Assert
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReturnFalse_IfObjetIsNotAvailable()
        {
            // Arrange
            var objetDePret = new ObjetDePret("chaise");
            objetDePret.Emprunte("Alain"); // Utilisation correcte de la méthode

            // Act
            var actual = objetDePret.Emprunte("Albert");

            // Assert
            Assert.IsFalse(actual, "Un objet déjà emprunté ne devrait pas pouvoir être emprunté à nouveau.");
        }
    }
}