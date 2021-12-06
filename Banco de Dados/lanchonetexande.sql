-- phpMyAdmin SQL Dump
-- version 4.7.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 02-Dez-2021 às 23:11
-- Versão do servidor: 5.6.34
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lanchonetexande`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbclientes`
--

CREATE TABLE `tbclientes` (
  `cpf` varchar(14) NOT NULL,
  `dataNasc` varchar(10) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `endereco` varchar(60) NOT NULL,
  `comp` varchar(15) NOT NULL,
  `bairro` varchar(40) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `celular` varchar(16) NOT NULL,
  `email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbclientes`
--

INSERT INTO `tbclientes` (`cpf`, `dataNasc`, `nome`, `cep`, `endereco`, `comp`, `bairro`, `cidade`, `uf`, `telefone`, `celular`, `email`) VALUES
('222.222.222-22', '11/1/2002', 'Moquidesia', '09132-130', 'R CRUZ DE MALTA', '25', 'JARDIM SANTO ANDRE', 'SANTO ANDRE', 'SP', '(11) 1111-1111', '(22) 22222-2222', 'moq@moq.com');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbfuncionarios`
--

CREATE TABLE `tbfuncionarios` (
  `cpf` varchar(14) NOT NULL,
  `dataNasc` varchar(10) NOT NULL,
  `funcao` varchar(50) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `endereco` varchar(60) NOT NULL,
  `comp` varchar(15) NOT NULL,
  `bairro` varchar(40) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `celular` varchar(16) NOT NULL,
  `email` varchar(60) NOT NULL,
  `login` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbfuncionarios`
--

INSERT INTO `tbfuncionarios` (`cpf`, `dataNasc`, `funcao`, `nome`, `cep`, `endereco`, `comp`, `bairro`, `cidade`, `uf`, `telefone`, `celular`, `email`, `login`, `senha`) VALUES
('111.111.111-11', '12/2/2021', 'Atendente', 'Abuble', '09170-170', 'R ALVARES MACIEL', '11', 'JARDIM VILA RICA', 'SANTO ANDRE', 'SP', '(11) 1111-1111', '(12) 22222-2222', 'adad@ada.com', 'login', 'senha'),
('535.127.338-16', '01-Nov-02', 'Dono', 'PEDRO H', '09132-130', 'RUA CRUZ DE MALTA, 53', 'CASA', 'JARDIM SANTO ANDRÉ', 'SANTO ANDRÉ', 'SP', '(11) 4453-2524', '(11) 99718-3394', 'P.KIELBLOCK@GMAIL.COM', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbpedidos`
--

CREATE TABLE `tbpedidos` (
  `idcliente` int(10) NOT NULL,
  `cliente` varchar(50) NOT NULL,
  `data` date NOT NULL,
  `produto` varchar(50) NOT NULL,
  `qtd` int(10) NOT NULL,
  `preco` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbpedidos`
--

INSERT INTO `tbpedidos` (`idcliente`, `cliente`, `data`, `produto`, `qtd`, `preco`) VALUES
(10, 'Donizete', '2021-12-02', 'Cachorro Quente', 1, 10.00),
(11, 'Azevedo', '2021-12-02', 'Coca Cola', 1, 7.00),
(12, 'Luiz', '2021-12-02', 'Sucão do Xande', 1, 5.00),
(13, 'Donizete', '2021-12-02', 'Sucão do Xande', 2, 10.00),
(14, 'Angela', '2021-12-02', 'Água Mineral', 1, 2.50);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbprodutos`
--

CREATE TABLE `tbprodutos` (
  `id` int(10) NOT NULL,
  `produtos` varchar(60) NOT NULL,
  `preco` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbprodutos`
--

INSERT INTO `tbprodutos` (`id`, `produtos`, `preco`) VALUES
(1, 'Cachorro Quente', 10.00),
(2, 'Pizza Calabresa', 25.00),
(3, 'Sucão do Xande', 5.00),
(4, 'Coca Cola', 7.00),
(5, 'Água Mineral', 2.50),
(6, 'Lanchão do Xande', 15.00),
(7, 'Salada do Xande', 12.00),
(8, 'Guaraná', 6.00),
(9, 'PF Do Brabo', 9.00),
(10, 'Coxinha Top', 3.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbclientes`
--
ALTER TABLE `tbclientes`
  ADD PRIMARY KEY (`cpf`);

--
-- Indexes for table `tbfuncionarios`
--
ALTER TABLE `tbfuncionarios`
  ADD PRIMARY KEY (`cpf`);

--
-- Indexes for table `tbpedidos`
--
ALTER TABLE `tbpedidos`
  ADD PRIMARY KEY (`idcliente`);

--
-- Indexes for table `tbprodutos`
--
ALTER TABLE `tbprodutos`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbpedidos`
--
ALTER TABLE `tbpedidos`
  MODIFY `idcliente` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tbprodutos`
--
ALTER TABLE `tbprodutos`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
