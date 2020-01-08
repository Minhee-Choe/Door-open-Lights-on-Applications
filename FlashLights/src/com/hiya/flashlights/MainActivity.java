package com.hiya.flashlights;

import android.hardware.Camera;
import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.LinearLayout.LayoutParams;

public class MainActivity extends Activity {

	private Camera mCamera = null;
	private boolean isCameraOn = false;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		
		LinearLayout linearlayout = new LinearLayout(this);
		LinearLayout.LayoutParams linearParams = new LinearLayout.LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT);
		linearlayout.setLayoutParams(linearParams);
		
		Button btnSwitch = new Button(this);
		btnSwitch.setText("ON/OFF");
		
		btnSwitch.setOnTouchListener(new View.OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				
				switch(event.getAction()) 
				{
				
				case MotionEvent.ACTION_UP :
					if(isCameraOn) {
						mCamera.release();
						isCameraOn = false;
					}
					else {
						mCamera = Camera.open();
						Camera.Parameters mCameraParameters = mCamera.getParameters();
						mCameraParameters.setFlashMode(Camera.Parameters.FLASH_MODE_TORCH);
						mCameraParameters.setFocusMode(Camera.Parameters.FOCUS_MODE_INFINITY);
						mCamera.setParameters(mCameraParameters);
						mCamera.startPreview();
						isCameraOn = true;
					}
					
					break;
				
				}
				
				return false;
			}
		});
			
		LayoutParams btnParams = new LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT);
		btnSwitch.setLayoutParams(btnParams);
		
		linearlayout.addView(btnSwitch);
		
		setContentView(linearlayout);
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_main, menu);
		return true;
	}

}
