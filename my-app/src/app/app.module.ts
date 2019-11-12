import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveFormsModule, Validators } from '@angular/forms';
import { NameEditorComponent } from './name-editor/name-editor.component';
import { ProfileEditorComponent } from './profile-editor/profile-editor.component';
//import { FormControl } from '@angular/forms';
//import { FormGroup  } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NameEditorComponent,
    ProfileEditorComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule

    // FormsModule,
    // FormControl,
    // FormGroup




  ],
  exports: [
    NameEditorComponent,
    ProfileEditorComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
