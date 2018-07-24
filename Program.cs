using System;
using Com.Expload;

[Program]
class MyProgram {

    public static Bytes EBACOC_BYTES_VALUE = new Bytes(new byte[] {0xEB, 0xAC, 0x0C});

    Mapping<Bytes, Bytes> weapons = new Mapping<Bytes, Bytes>();
    Mapping<Bytes, Bytes> cases = new Mapping<Bytes, Bytes>();

    public void setWeaponData(Bytes addr, Bytes data) {
        weapons.put(addr, data);
    }

    public Bytes getWeaponData(Bytes addr) {
        return weapons.getDefault(addr, EBACOC_BYTES_VALUE);
    }

    public void setCasesData(Bytes addr, Bytes data) {
        cases.put(addr, data);
    }

    public Bytes getCasesData(Bytes addr) {
        return cases.getDefault(addr, EBACOC_BYTES_VALUE);
    }

}
class MainClass { public static void Main() {} }