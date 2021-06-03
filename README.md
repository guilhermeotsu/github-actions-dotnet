# Github Action - dotnet


## Primeiros passos

É necessario adicionar uma pasta chamada `.github` na raiz do seu projeto, e dentro dessa pasta adionar um subdiretório `workflows`, é dentra dessa pasta que o Github procura os arquivos de configuraçoes do fluxo de trabalho que serao aplicados e executados. Dentro dessa pasta adicionamos um ou mais arquivos *YAML*, cada um fornece a configuraçao para um fluxo de trabalho. 

## Configurando o primeiro arquivos YAML

Arquivos YAML depende da identacao e nao das chaves. Sao bastante utilizados para fazer automacoes no geral, como containerizacao, configuraçoes de clound, etc.

Primeiro adicionamos um nome para o seu workflow, nao e algo necessario mas e uma boa pratica, que será exibido na UI do Github Actions.
