import React from 'react';
import './Home.css';

class Home extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            error: null,
            isLoaded: false,
            items: []
        }
    }

    componentDidMount() {
        fetch("http://localhost:5000/api/ticket")
        .then(res => res.json())
        .then(
            (result) => {
                console.log(result);
                this.setState({
                    isLoaded: true,
                    items: result
                });
            },
            (error) => {
                this.setState({
                    isLoaded: true,
                    error
                });
            }
        )
    }

    orderTicket(id) {
        fetch('http://localhost:5000/api/order?id=10', {method: 'POST'})
        .then(res => res.json())
        .then(
            (result) => {
                alert(result);
            }
        )
    }
    
    render() {
        const { items } = this.state;

        return (
            <table>
                <thead>
                    <tr>
                        <td>
                            Tickets
                        </td>
                        <td>

                        </td>
                    </tr>
                </thead>
                <tbody>
                {items.map(item => (
                    <tr key={item.id}>
                        <td>
                            {item.name}
                        </td>
                        <td>
                            <button onClick={() => this.orderTicket(item.id)}>
                                Order
                            </button>
                        </td>
                    </tr>
                ))}
                </tbody>
            </table>
        );
    }
}

export default Home;
