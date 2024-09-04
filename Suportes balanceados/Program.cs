// See https://aka.ms/new-console-template for more information
static bool IsValidarSequenciaString(string s) {
    Stack<char> Pilha = new Stack<char>(); 
    Dictionary<char, char> StringMap = new Dictionary<char, char>()
    {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
    };

    foreach (char c in s) {
        if (StringMap.ContainsValue(c)) {
            Pilha.Push(c);
        } else if (StringMap.ContainsKey(c)) {
            if (Pilha.Count == 0 || Pilha.Pop() != StringMap[c]) {
                return false;
            }
        } else {
            return false; // Como a especificação não mencionava a necessidade de considerar outros caracteres, defini que, se houver um caractere que não esteja no dicionário, a sequência da string será imediatamente considerada inválida, retornando 'false'.
        }
    }

    return Pilha.Count == 0;
}


    Console.WriteLine(IsValidarSequenciaString("(){}[]"));  
    Console.WriteLine(IsValidarSequenciaString("[{()}](){}")); 
    Console.WriteLine(IsValidarSequenciaString("[]{()"));  
    Console.WriteLine(IsValidarSequenciaString("[{()}]")); 

