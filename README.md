# Github Action - dotnet

Link de referencia [aqui](https://www.stevejgordon.co.uk/getting-started-with-github-actions-for-dotnet-developers).

## Primeiros passos

É necessario adicionar uma pasta chamada `.github` na raiz do seu projeto, e dentro dessa pasta adionar um subdiretório `workflows`, é dentra dessa pasta que o Github procura os arquivos de configuraçoes do fluxo de trabalho que serao aplicados e executados. Dentro dessa pasta adicionamos um ou mais arquivos *YAML*, cada um fornece a configuraçao para um fluxo de trabalho. 

## Configurando o primeiro arquivos YAML

Arquivos YAML depende da identacao e nao das chaves. Sao bastante utilizados para fazer automacoes no geral, como containerizacao, configuraçoes de clound, etc.


### 1 - Nomeando o Workflow

Primeiro adicionamos um nome para o seu workflow, nao e algo necessario mas e uma boa pratica, que será exibido na UI do Github Actions.

### 2 - Configurando triggers

As trigger serao disparados conforme uma açao ocorra. Existem muitas possibilidade de automaçao/trigger que podem ser encontrada [Nesta documentaçao](https://docs.github.com/en/actions/reference/events-that-trigger-workflows).

Trigger sao específicadas na seçao `on` de um arquivo YAML. Como por exemplo:
```yaml
on:
	push:
		branches:
			- main
	pull_request:
		branches:
			- main
```
Neste exemplo estamos especificando que queremos acionar o workflow quando um push ou PR acontece para a branch main

### 3 - Workflows Jobs

Nos jobs especificamos que tarefas serao executadas em cada parte do nosso workflow. Cada job deve conter um Job ID, que deve ser um valor alfanumericos, nao podendo conter espaços. Para legibilidade do Job nos incluimos um `name` onde pode ter espaços. Como por exemplo:
```yaml
jobs:
	first_job:
		name: First job
	second_job:
		name: Second job
```

