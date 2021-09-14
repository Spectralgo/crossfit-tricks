<script context="module" lang="ts">
	import { LoadHome } from '../stores/Loaders/HomeLoader';
	export const load = LoadHome;
</script>

<script>
import { HomeStore } from '../stores/api-stores/HomeStore';
import { Count } from '../stores/api-stores/TestStore';

export let HomeApi

</script>

<svelte:head>
	<title>Home</title>
</svelte:head>

<section>
	<h1>Loader home api call:<br /> {HomeApi.IndexResponse}</h1>
	<h1>
		Store home api call:<br />
		{$HomeStore}
	</h1>
	<h1>
		{$Count}
	</h1>
</section>

<style>
</style>
