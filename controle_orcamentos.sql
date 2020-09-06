-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 06-Set-2020 às 01:30
-- Versão do servidor: 10.4.13-MariaDB
-- versão do PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `controle_orcamentos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `idCliente` int(11) NOT NULL,
  `ativoCliente` int(11) NOT NULL,
  `nomeCliente` varchar(100) NOT NULL,
  `cpfCliente` varchar(14) NOT NULL,
  `rgCliente` varchar(15) NOT NULL,
  `fonefixoCliente` varchar(14) NOT NULL,
  `fonecelularCliente` varchar(15) NOT NULL,
  `emailCliente` varchar(100) NOT NULL,
  `cepCliente` varchar(10) NOT NULL,
  `logradouroCliente` varchar(100) NOT NULL,
  `numeroCliente` int(11) NOT NULL,
  `complementoCliente` varchar(50) NOT NULL,
  `bairroCliente` varchar(50) NOT NULL,
  `cidadeCliente` varchar(50) NOT NULL,
  `estadoCliente` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`idCliente`, `ativoCliente`, `nomeCliente`, `cpfCliente`, `rgCliente`, `fonefixoCliente`, `fonecelularCliente`, `emailCliente`, `cepCliente`, `logradouroCliente`, `numeroCliente`, `complementoCliente`, `bairroCliente`, `cidadeCliente`, `estadoCliente`) VALUES
(1, 0, 'ffsdf', 'sf', 'dfs', 'fs', 'fs', 'fsdf', '', 'fsdfsd', 0, '', '', 'fsd', ''),
(4, 0, 'ASDASDASD', '102,120,120-12', '212121', '(47)7215-4054', '(54)5454 -', 'asdadad', '88,821-212', 'ASDASDASDASDA', 212155, 'DASDASDAD', 'DADAD', 'DADA', 'DS'),
(6, 0, 'ADASDSAD', '   ,   ,   -', 'sdasd', '(  )    -', '(  )     -', '', '  ,   -', 'DAS', 0, '', 'ASD', 'DS', ''),
(7, 0, '5555', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(8, 0, 'ASAFSDF', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(9, 0, 'ASDASDAS', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(11, 0, 'NOME TESTEFAASD', '123,123,123-67', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(12, 0, 'NOME TESTE DE ALTERACAO', '123,123,123-67', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(13, 0, 'NOME TESTE NOVO', '123,123,123-67', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(14, 0, 'KJ JHB BNNJB', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(15, 0, 'QWEQEQWEQWEQWEQWEWQEQWEQ', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(16, 0, 'FSDFSDFSDFSD', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(17, 0, 'NOME', '123,456,789-00', 'RG', '(47)8888-8888', '(47)99999-9999', 'email', '88,888-888', 'LOGRADOURO', 11111, 'COMPLEMENTO', 'BAIRRO', 'CIDADE', 'UF'),
(18, 0, '', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(19, 0, 'ADADAS', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', 'ITAJAI NOVA', ''),
(20, 0, 'DASDASDASDAS', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(21, 0, 'FSDFDASFSDFSDFDS', '   ,   ,   -', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', ''),
(22, 0, 'FULADO DE TAL', '999,999,999-99', '1.123.456', '(47)9999-9999', '(47)99999-9999', 'fulanodetal@gmail.com', '99,999-999', 'LOGRADOURO FULANO', 123, 'COMPLEMENTO FULANO', 'BAIRRO FULADO', 'CIDADE FULANO', 'SC'),
(23, 0, 'SSFSFS', '454.054.054-05', '', '(  )    -', '(  )     -', '', '  ,   -', '', 0, '', '', '', '');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idCliente`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
