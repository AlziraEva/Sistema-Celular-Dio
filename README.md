# Sistema de Celular 📱
![status](https://img.shields.io/badge/status-%20concluido-green)

## 📝Sobre o Projeto
 Responsável por modelar um sistema que trabalha com celulares. Para isso, foi implementado uma abstração de um celular e disponibilizando maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos. Foi criado um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone.

## Modelo do Projeto
![Diagrama classes](Imagens/diagrama.png)

## 🔄 Funcionalidades
- Ligar para um número especifico
- Receber ligação
- Instalar aplicativo
- informações do celular

## 📌 Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## ⚙Tecnologias e Linguagens Utilizadas
<div>
<img align="center" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" 
title="C#"  width="50" height="50"/>
<img align="center" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" 
title=".Net"  width="50" height="50"/>
<img align="center" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/git/git-plain-wordmark.svg" 
title="Git" width="50" height="50"/>
</div>          

## 🤝Contribuindo

1. Faça um fork deste repositório

2. Crie uma branch para sua feature:

```
    git checkout -b feature/nova-feature
```
3. Faça commit das suas alterações:

```
    git commit -m Adiciona nova feature
```
    
4. Envie as alterações para o seu fork:

```     
    git push origin feature/nova-feature
``` 
 
5. Abra um pull request neste repositório

## 👩‍💻Autores

- [Alzira Eva](https://github.com/AlziraEva)👩

