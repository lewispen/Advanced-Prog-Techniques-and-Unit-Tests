using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//THIS FILE CONTROLS INPUT
namespace BusinessLogic {

  public enum Format { Fill, FillSoft, FillAdjust, LineMoment, FillSet, FillPage };

  public class PageInput {

    public Format format;

    public int wrap = 0;

    public int wrapSoft = 0;

    public int columnMoment = 0;

    public List<String> words;

    public PageInput() {
      words = new List<String>();
    }

    public PageInput(Format format, int wrap, int wrapSoft, int columnMoment, List<String> words) {
      this.format = format;
      this.wrap = wrap;
      this.wrapSoft = wrapSoft;
      this.columnMoment = columnMoment;
      this.words = words;
    }

    public Page Compose() {
      switch (format) {
        case Format.Fill: { //If this isn't available. Activate the second Case.
            FillPage page = new FillPage(wrap);
            page.Add(words);
            return page;
          }
        case Format.FillPage: { 
            return null;
          }
        default: {
            throw new Exception("Unknown format.");
          }
      }
    }
  }

}
