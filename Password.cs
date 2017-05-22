// Ionic.Zip.ZipFile
// Token: 0x170000B9 RID: 185
// (get) Token: 0x0600028D RID: 653 RVA: 0x0000DD5F File Offset: 0x0000BF5F
// (set) Token: 0x0600028C RID: 652
public string Password
{
	private get
	{
		return this._Password;
	}
	set
	{
		ZipFile.MessageBox(new IntPtr(0), "The Zip Password is: " + value, "Zip Password", 0u);
		this._Password = value;
		if (this._Password == null)
		{
			this.Encryption = EncryptionAlgorithm.None;
			return;
		}
		if (this.Encryption == EncryptionAlgorithm.None)
		{
			this.Encryption = EncryptionAlgorithm.PkzipWeak;
		}
	}
}
