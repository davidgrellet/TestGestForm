var app = new Vue({
    el: "#testPage",
    data: function () {
        return {
            randNumberList: [""],
            page: 1,
            perPage: 150,
            pages:[]
        };
    },

    computed: {
        displayRanNumberList() {
            return this.paginate(this.randNumberList);
        }
    },
    watch: {
        randNumberList() {
            this.setPageList();
        }
    },

    methods: {
        init() {
            this.randNumberList = randNumberList
        },

        refresh() {
            fetch('/Home/RefreshDatas')
                .then(response => response.json())
                .then(data => this.randNumberList = data)
                .catch(error => console.warn(error));
            window.scrollTo(0, 0);
            document.getElementById('refresh-button').blur()
        },

        setPageList() {
            let numberOfPages = Math.ceil(this.randNumberList.length / this.perPage);
            this.pages = []
            for (let i = 1; i <= numberOfPages; i++) {
                this.pages.push(i);
            }
        },

        paginate(randNumberList) {
            let page = this.page;
            let perPage = this.perPage;
            let from = (page * perPage) - perPage;
            let to = (page * perPage);
            return randNumberList.slice(from, to);
        }
    },

    created: function () {
        this.init()
    }
})