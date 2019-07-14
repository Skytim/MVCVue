new Vue({
  el: '#app',
  data: {
    items: null,
    form: {
      email: '',
      name: ''
    },
    show: true
  },
  mounted() {
    baseInstance.get('/SampleData')
      .then(response => {
        this.items = response.data;
      });
  },
  methods: {
    onSubmit(evt) {
      evt.preventDefault();
      baseInstance.post('/PersonData', this.form)
        .then(response => {
          console.log(response);
          this.reset();
        })
        .catch(function (error) {
          console.log(error);
        });
    },
    onReset(evt) {
      evt.preventDefault();
      // Reset our form values
      this.reset();
    },
    reset() {
      this.form.email = '';
      this.form.name = '';

      this.show = false;
      this.$nextTick(() => {
        this.show = true;
      })
    }
  }
})
