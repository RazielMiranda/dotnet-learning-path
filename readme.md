# .NET Learning path:

Criando um novo projeto console

        dotnet new --help
        dotnet new console -h
        dotnet new console -n nome_projeto

Comando de saida no console:

        Console.WriteLine("Hello World!");

### Tipos no C#:

Númericos:

- sbyte
- short
- int
- long
- byte
- ushort
- uint
- ulong

Unicodes:
- char

Flutuantes:

- float
- double
- decimal

Booleano:
- bool

Outros:
- enum, 
- struct e tipos 
- nullable (?int pode ser nulo)

Variaveis de tipo de referencia armazenam referencia a seus dados,
É possivel que duas variaveis façam referencias ao mesmo objeto e
portanto, que operações em uma variavel afetem o objeto referenciado
pela outra variavel.

Referencia:
- class, object, string (tipos de classe)
- int[], int[1,2] (Arrays)
- interface e delegare