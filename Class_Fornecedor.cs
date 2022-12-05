using System;
public class Class_Fornecedor
{

    //Atributos
    private int id;
    private String data;
    private String produto;
    private int tempo_cont;
    private String endereco;
    private String CEP;
    private String nome;
    private int telefone;
    private String email;
    private String CNPJ;
   

    //Metodos contrutores
    public Class_Fornecedor()
    {
        this.id = 0;
        this.data = "";
        this.produto = "";
        this.tempo_cont = 0;
        this.endereco = "";
        this.CEP = "";
        this.nome = "";
        this.telefone = 0;
        this.email = "";
        this.CNPJ = "";
    }

    public Class_Fornecedor(int p_id, String p_data, String p_produto, int p_tempo_cont, String p_endereco, String p_CEP, String p_nome, int p_telefone, String p_email, String p_CNPJ)
    {
        this.id = p_id;
        this.data = p_data;
        this.produto = p_produto;
        this.tempo_cont = p_tempo_cont;
        this.endereco = p_endereco;
        this.CEP = p_CEP;
        this.nome = p_nome;
        this.telefone = p_telefone;
        this.email = p_email;
        this.CNPJ = p_CNPJ;
    }

    //Metodo get-set do id
    public int getId() { return this.id; }
    public void setId(int p_id) { this.id = p_id; }

    //Metodo get-set da data
    public String getData() { return this.data; }
    public void setData(String p_data) { this.data = p_data; }

    //Metodo get-set do produto
    public String getProduto() { return this.produto; }
    public void setProduto(String p_produto) { this.produto = p_produto; }

    //Metodo get-set do tempo de contrato
    public int getTempo_cont() { return this.tempo_cont; }
    public void setTempo_cont(int p_tempo_cont) { this.tempo_cont = p_tempo_cont; }

    //Metodo get-set do endereço
    public String getEndereco() { return this.endereco; }
    public void setEndereco(String p_endereco) { this.endereco = p_endereco; }

    //Metodo get-set do CEP
    public String getCEP() { return this.CEP; }
    public void setCEP(String p_CEP) { this.CEP = p_CEP; }

    //Metodo get-set do Nome
    public String getNome() { return this.nome; }
    public void setNome(String p_nome) { this.nome = p_nome; }

    //Metodo get-set do Telefone
    public int getTelefone() { return this.telefone; }
    public void setTelefone(int p_telefone) { this.telefone = p_telefone; }

    //Metodo get-set do Email
    public String getEmail() { return this.email; }
    public void setEmail(String p_email) { this.email = p_email; }

    //Metodo get-set do CNPJ
    public String getCNPJ() { return this.CNPJ; }
    public void setCNPJ(String p_CNPJ) { this.CNPJ = p_CNPJ; }
}
