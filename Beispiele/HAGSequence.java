package HAGScriptClient.Collections;

import java.io.Serializable;

public class HAGSequence implements Serializable {
	private static final long serialVersionUID = 33429807;
	
	private long Start = -1;
	private long OffSet = 0; // Braucht man normalerweise nicht
	private String InputMode = ""; // z.B. collection oder lightfade
	private String InputPraefix = ""; // z.B. L1 oder Q1
	private int Value = -1; // 0 - 100 | 0 = Aus | >0 Ein - 100d
	private boolean Fade = false;
	private int FadeSpeed = 100;
	private boolean Ignore = false; // Beim RunHAGSequence wird Ignore = true gesetzt, wenn schon ausgeführt
	private String Comment = ""; // Licht fuer Refain oder so
	
	public long GetStart() {
		return Start;
	}
	
	public void SetStart(long start) {
		Start = start;
	}

	public long GetOffSet() {
		return OffSet;
	}
	
	public void SetOffSet(long offSet) {
		OffSet = offSet;
	}
	
	public String GetInputPraefix() {
		return InputPraefix;
	}
	
	public void SetInputPraefix(String inputPraefix) {
		InputPraefix = inputPraefix;
	}
	
	public int GetValue() {
		return Value;
	}
	
	public void SetValue(int value) {
		Value = value;
	}
	
	public boolean isFade() {
		return Fade;
	}
	
	public void SetFade(boolean fade) {
		Fade = fade;
	}
	
	public int GetFadeSpeed() {
		return FadeSpeed;
	}
	
	public void SetFadeSpeed(int fadeSpeed) {
		FadeSpeed = fadeSpeed;
	}

	public String GetInputMode() {
		return InputMode;
	}

	public void SetInputMode(String inputMode) {
		InputMode = inputMode;
	}

	public boolean IsIgnore() {
		return Ignore;
	}

	public void SetIgnore(boolean ignore) {
		Ignore = ignore;
	}

	public String GetComment() {
		return Comment;
	}

	public void SetComment(String comment) {
		Comment = comment;
	}

	public String GetFade() {
		if(Fade)
			return "fade";
		return "";
	}
	
}


