-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.5-10.0.14-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para test
CREATE DATABASE IF NOT EXISTS `test` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `test`;


-- Copiando estrutura para tabela test.pokedex
CREATE TABLE IF NOT EXISTS `pokedex` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Criador` varchar(50) NOT NULL,
  `Nome` varchar(50) DEFAULT NULL,
  `Tipo` varchar(50) DEFAULT NULL,
  `ATK` int(11) DEFAULT NULL,
  `DEF` int(11) DEFAULT NULL,
  `HP` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela test.pokedex: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `pokedex` DISABLE KEYS */;
INSERT INTO `pokedex` (`Id`, `Criador`, `Nome`, `Tipo`, `ATK`, `DEF`, `HP`) VALUES
	(1, 'Sistema', 'Totodile', 'agua', 65, 64, 50),
	(2, 'Sistema', 'Cyndaquil', 'fogo', 52, 43, 39),
	(3, 'Sistema', 'Chikorita', 'planta', 49, 55, 45);
/*!40000 ALTER TABLE `pokedex` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
