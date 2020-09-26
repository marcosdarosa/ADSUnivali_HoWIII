-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 27-Set-2020 às 00:56
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
(26, 0, 'CLIENTE FULANO 1SAASDASDADASDASDASDA', '121.212.121-21', '12121', '(47)1212-1212', '(47)12121-2121', 'marcos@teste', '88.888-888', 'RUA', 123, 'CASA', 'BAIRRO', 'CIDADE', 'SC');

-- --------------------------------------------------------

--
-- Estrutura da tabela `consultores`
--

CREATE TABLE `consultores` (
  `idConsultor` int(11) NOT NULL,
  `ativoConsultor` int(11) NOT NULL,
  `nomeConsultor` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `grupos`
--

CREATE TABLE `grupos` (
  `idGrupo` int(11) NOT NULL,
  `ativoGrupo` int(11) NOT NULL,
  `descricaoGrupo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `marcas`
--

CREATE TABLE `marcas` (
  `idMarca` int(11) NOT NULL,
  `ativoMarca` int(11) NOT NULL,
  `descricaoMarca` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `orcamentos`
--

CREATE TABLE `orcamentos` (
  `idOrcamento` int(11) NOT NULL,
  `idConsultor` int(11) NOT NULL,
  `idCliente` int(11) NOT NULL,
  `dataOrcamento` date NOT NULL,
  `validadeOrcamento` date NOT NULL,
  `statusOrcamento` int(11) NOT NULL,
  `formapgtoOrcamento` varchar(100) NOT NULL,
  `totalbrutoOrcamento` decimal(14,2) NOT NULL,
  `totaldescontoOrcamento` decimal(10,2) NOT NULL,
  `totalliquidoOrcamento` decimal(14,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `orcamentositens`
--

CREATE TABLE `orcamentositens` (
  `idOrcamentoItem` int(11) NOT NULL,
  `idOrcamento` int(11) NOT NULL,
  `idProduto` int(11) NOT NULL,
  `quantidadeOrcamentoItem` decimal(10,2) NOT NULL,
  `valorunitarioOrcamentoItem` decimal(14,2) NOT NULL,
  `descontoOrcamentoItem` decimal(10,2) NOT NULL,
  `totalOrcamentoItem` decimal(14,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `idProduto` int(11) NOT NULL,
  `idGrupo` int(11) NOT NULL,
  `idMarca` int(11) NOT NULL,
  `ativoProduto` int(11) NOT NULL,
  `descricaoProduto` varchar(100) NOT NULL,
  `codigobarrasProduto` int(11) NOT NULL,
  `unidademedidaProduto` varchar(2) NOT NULL,
  `aplicacaoProduto` text NOT NULL,
  `qtdestoqueProduto` decimal(10,2) NOT NULL,
  `precovendaProduto` decimal(14,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idCliente`);

--
-- Índices para tabela `consultores`
--
ALTER TABLE `consultores`
  ADD PRIMARY KEY (`idConsultor`);

--
-- Índices para tabela `grupos`
--
ALTER TABLE `grupos`
  ADD PRIMARY KEY (`idGrupo`);

--
-- Índices para tabela `marcas`
--
ALTER TABLE `marcas`
  ADD PRIMARY KEY (`idMarca`);

--
-- Índices para tabela `orcamentos`
--
ALTER TABLE `orcamentos`
  ADD PRIMARY KEY (`idOrcamento`);

--
-- Índices para tabela `orcamentositens`
--
ALTER TABLE `orcamentositens`
  ADD PRIMARY KEY (`idOrcamentoItem`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`idProduto`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT de tabela `consultores`
--
ALTER TABLE `consultores`
  MODIFY `idConsultor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `grupos`
--
ALTER TABLE `grupos`
  MODIFY `idGrupo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `marcas`
--
ALTER TABLE `marcas`
  MODIFY `idMarca` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `orcamentos`
--
ALTER TABLE `orcamentos`
  MODIFY `idOrcamento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `orcamentositens`
--
ALTER TABLE `orcamentositens`
  MODIFY `idOrcamentoItem` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `idProduto` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
