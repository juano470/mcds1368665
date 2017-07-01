@extends('layouts.app')

@section('title', 'Adicionar Usuario')

@section('content')

<div class="row">
	<div class="col-md-6 col-md-offset-3">
		<h1 class="lead"> <i class="fa fa-plus"></i> Adicionar Usuario</h1>
		<hr>
		@if($errors->any())
		    <div class="alert alert-danger">
		    	<ul>
				@foreach($errors->all() as $error)
					<li> {{ $error }}</li>
				@endforeach
				</ul>
			</div>
		@endif 
		<form action="{{ url('user') }}" method="post" enctype="multipart/form-data">
			<div class="form-group">
				{{ csrf_field() }}
				<input type="text" name="name" class="form-control" value="{{ old('name') }}" placeholder="Nombre Completo">				
			</div>
			<div class="form-group">
				<input type="email" name="email" class="form-control" value="{{ old('email') }}" placeholder="Correo Electronico">
			</div>
			<div class="form-group">
				<input type="password" name="password" class="form-control" value="{{ old('password') }}" placeholder="Contraseña">
			</div>
			<div class="form-group">
				<select name="role" id="" class="form-control">
					<option value=""> Seleccione Rol...</option>
					<option value="Admin"> Administrador</option>
					<option value="Customer"> Cliente</option>
				</select>
			</div>
			<div class="form-group">
				<input type="file" class="hide" name="photo" id="upload" accept="image/*" >	
				<button type="button" class="btn btn-default btn-block" id="doUpload">
					<i class="fa fa-upload"></i>Subir Foto
				</button>			
			</div>
			<div class="form-group">
				<button type="submit" class="btn btn-success btn-block"><i class="fa fa-save"> Guardar</i></button>
			</div>
		</form>
	</div>	

</div>

@endsection
