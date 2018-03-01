using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Participantes.Controles;
namespace UnitTests
{
    [TestClass]
    public class UnitTestsParticipantesController
    {
        private ParticipantesController ParticipantesController = new ParticipantesController();

        [TestMethod]
        public void Validade_CPF()
        {
            Assert.IsTrue(ParticipantesController.isCPFCNPJ("55285752060", false), "Erro o CPF 55285752060 era válido");
            Assert.IsFalse(ParticipantesController.isCPFCNPJ("56164586002", false), "Erro o CPF 55285752060 era inválido");
            Assert.IsTrue(ParticipantesController.isCPFCNPJ("34194156000172", false), "Erro o CPF 34194156000172 era válido");
            Assert.IsFalse(ParticipantesController.isCPFCNPJ("34194156000173", false), "Erro o CPF 34194156000173 era inválido");
        }

        [TestMethod]
        public void Validade_InscricaoEstadual()
        {
            Assert.IsTrue(ParticipantesController.ValidarInscricaoEstadual("SP","578064970254"), "Inscrição Estadual Valida");
            Assert.IsFalse(ParticipantesController.ValidarInscricaoEstadual("RS", "578064970254"), "Inscrição Estadual Inválida");
            Assert.IsTrue(ParticipantesController.ValidarInscricaoEstadual("TO", "21037958354"), "Inscrição Estadual Valida");
            Assert.IsFalse(ParticipantesController.ValidarInscricaoEstadual("RS", "21037958354"), "Inscrição Estadual Inválida");
            Assert.IsTrue(ParticipantesController.ValidarInscricaoEstadual("RS", "1939646577"), "Inscrição Estadual Valida");
            Assert.IsFalse(ParticipantesController.ValidarInscricaoEstadual("TO", "1939646577"), "Inscrição Estadual Inválida");
        }
    }
}
