using System;
using MonoTouch.Dialog;
namespace HelloIphone2
{
	
	public class MyBarcodeDialog : DialogViewController
    {
		public MyBarcodeDialog () : base(null)
        {
            initView();
        }
        
        EntryElement txtBarcode;
        
        private void initView()
        {
            var root = new RootElement("Simple Barcode Example");
            var section = new Section("Collect Barcode");
            
            txtBarcode = new EntryElement("Barcode", "Please scan a barcode.", "");
            
            section.Add(txtBarcode);
            root.Add(section);
            
            this.Root = root;
        }
    }
	
}

